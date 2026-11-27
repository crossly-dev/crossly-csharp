using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Crossly.Webhooks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Crossly.AspNetCore
{
    /// <summary>Options shared by the middleware and the endpoint filter.</summary>
    public sealed class CrosslyWebhookOptions
    {
        /// <summary>The endpoint's signing secret (Settings → Webhooks). Required.</summary>
        public string Secret { get; set; } = "";

        /// <summary>Largest accepted clock drift, in seconds.</summary>
        public int ToleranceSeconds { get; set; } = CrosslyWebhooks.DefaultToleranceSeconds;

        /// <summary>Bodies larger than this are refused with 413 before any of it is buffered past the limit.</summary>
        public long MaxBodyBytes { get; set; } = 5 * 1024 * 1024;
    }

    /// <summary>
    /// Verifies the <c>Crossly-Signature</c> of every request under <c>path</c> before the rest of the pipeline runs.
    /// A request that does not verify is answered 400 <c>{"error":{"code":"&lt;reason&gt;"}}</c>. One that does
    /// carries the verified JSON in <see cref="CrosslyWebhookHttpContextExtensions.GetCrosslyWebhookBody"/>, and its
    /// body is rewound, so model binding (<c>[FromBody]</c>) still reads it.
    /// </summary>
    public sealed class CrosslyWebhookMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly PathString _path;
        private readonly CrosslyWebhookOptions _options;

        public CrosslyWebhookMiddleware(RequestDelegate next, PathString path, CrosslyWebhookOptions options)
        {
            _next = next;
            _path = path;
            _options = CrosslyWebhookVerifier.Validate(options);
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (!context.Request.Path.StartsWithSegments(_path))
            {
                await _next(context);
                return;
            }
            context.Request.EnableBuffering();
            var failure = await CrosslyWebhookVerifier.VerifyAsync(context, _options);
            if (failure != null)
            {
                await failure.ExecuteAsync(context);
                return;
            }
            context.Request.Body.Position = 0;
            await _next(context);
        }
    }

    /// <summary>
    /// Minimal-API endpoint filter: <c>app.MapPost("/webhooks/crossly", handler).AddCrosslyWebhookVerification(secret)</c>.
    /// The handler reads the verified JSON with <c>context.GetCrosslyWebhookBody()</c>. Endpoint filters run after
    /// parameter binding, so the handler must not bind the body itself (take <c>HttpContext</c> or
    /// <c>HttpRequest</c>); to keep <c>[FromBody]</c>, use <see cref="CrosslyWebhookMiddleware"/> instead.
    /// </summary>
    public sealed class CrosslyWebhookEndpointFilter : IEndpointFilter
    {
        private readonly CrosslyWebhookOptions _options;

        public CrosslyWebhookEndpointFilter(CrosslyWebhookOptions options) => _options = CrosslyWebhookVerifier.Validate(options);

        public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
        {
            var failure = await CrosslyWebhookVerifier.VerifyAsync(context.HttpContext, _options);
            return failure ?? await next(context);
        }
    }

    /// <summary>The verified body, after the middleware or filter ran.</summary>
    public static class CrosslyWebhookHttpContextExtensions
    {
        internal const string ItemKey = "Crossly.Webhooks.Body";

        /// <summary>The verified webhook JSON. Throws when no Crossly verification ran on this request.</summary>
        public static string GetCrosslyWebhookBody(this HttpContext context) =>
            context.Items.TryGetValue(ItemKey, out var body) && body is string s
                ? s
                : throw new InvalidOperationException(
                    "No verified Crossly webhook on this request: add UseCrosslyWebhooks(...) or AddCrosslyWebhookVerification(...).");
    }

    /// <summary>Registration helpers.</summary>
    public static class CrosslyWebhookExtensions
    {
        /// <summary>Verify every request under <paramref name="path"/> (e.g. "/webhooks/crossly").</summary>
        public static IApplicationBuilder UseCrosslyWebhooks(this IApplicationBuilder app, PathString path, string secret) =>
            app.UseCrosslyWebhooks(path, new CrosslyWebhookOptions { Secret = secret });

        public static IApplicationBuilder UseCrosslyWebhooks(this IApplicationBuilder app, PathString path, CrosslyWebhookOptions options) =>
            app.UseMiddleware<CrosslyWebhookMiddleware>(path, options);

        /// <summary>Verify the Crossly signature before this endpoint's handler runs.</summary>
        public static TBuilder AddCrosslyWebhookVerification<TBuilder>(this TBuilder builder, string secret)
            where TBuilder : IEndpointConventionBuilder =>
            builder.AddCrosslyWebhookVerification(new CrosslyWebhookOptions { Secret = secret });

        public static TBuilder AddCrosslyWebhookVerification<TBuilder>(this TBuilder builder, CrosslyWebhookOptions options)
            where TBuilder : IEndpointConventionBuilder =>
            builder.AddEndpointFilter(new CrosslyWebhookEndpointFilter(options));
    }

    internal static class CrosslyWebhookVerifier
    {
        internal static CrosslyWebhookOptions Validate(CrosslyWebhookOptions options)
        {
            if (options == null || string.IsNullOrEmpty(options.Secret))
            {
                throw new ArgumentException("A Crossly webhook signing secret is required (Settings → Webhooks).", nameof(options));
            }
            return options;
        }

        /// <summary>Null when the request verified (its body is then in HttpContext.Items), else the response to send.</summary>
        internal static async Task<IResult?> VerifyAsync(HttpContext context, CrosslyWebhookOptions options)
        {
            var request = context.Request;
            if (request.ContentLength > options.MaxBodyBytes) return Reject(StatusCodes.Status413PayloadTooLarge, "payload_too_large");
            using var buffer = new MemoryStream();
            var chunk = new byte[8192];
            int n;
            while ((n = await request.Body.ReadAsync(chunk, 0, chunk.Length, context.RequestAborted)) > 0)
            {
                if (buffer.Length + n > options.MaxBodyBytes) return Reject(StatusCodes.Status413PayloadTooLarge, "payload_too_large");
                buffer.Write(chunk, 0, n);
            }
            try
            {
                var body = CrosslyWebhooks.Verify(
                    buffer.ToArray(), request.Headers["Crossly-Signature"].ToString(), options.Secret, options.ToleranceSeconds);
                context.Items[CrosslyWebhookHttpContextExtensions.ItemKey] = body;
                return null;
            }
            catch (CrosslyWebhooks.VerificationException e)
            {
                return Reject(StatusCodes.Status400BadRequest, e.Reason);
            }
        }

        private static IResult Reject(int status, string code) =>
            Results.Json(new { error = new { code, message = "Crossly webhook rejected" } }, (JsonSerializerOptions?)null, "application/json", status);
    }
}
