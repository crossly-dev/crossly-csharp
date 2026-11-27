using System;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Crossly;
using net.crossly.Client;
using Polly;
using RestSharp;

namespace net.crossly
{
    /// <summary>Options for <see cref="CrosslyClient"/>.</summary>
    public sealed class CrosslyClientOptions
    {
        /// <summary>A Personal Access Token (<c>crossly_pat_…</c>, Settings → Developer) or a seller OAuth token.</summary>
        public string Token { get; set; }

        /// <summary>Default https://crossly.net/api.</summary>
        public string BasePath { get; set; } = "https://crossly.net/api";

        /// <summary>Retries after a 429, a 5xx or a connection failure (default 3; 0 turns retrying off).</summary>
        public int MaxRetries { get; set; } = 3;

        /// <summary>Timeout of each attempt (default 30 s).</summary>
        public TimeSpan Timeout { get; set; } = TimeSpan.FromSeconds(30);

        /// <summary>The longest Retry-After the client waits out (default 60 s); a longer one is returned as the error.</summary>
        public TimeSpan MaxRetryAfter { get; set; } = TimeSpan.FromSeconds(60);

        /// <summary>Appended to the User-Agent, e.g. "my-app/1.4".</summary>
        public string UserAgent { get; set; }
    }

    /// <summary>
    /// The Crossly seller client: a configured <see cref="Configuration"/> plus retries, idempotency keys and typed
    /// errors around the generated API classes.
    /// <code>
    /// var crossly = new CrosslyClient(Environment.GetEnvironmentVariable("CROSSLY_TOKEN"));
    /// var listings = crossly.Api&lt;ListingsApi&gt;();
    /// </code>
    /// </summary>
    /// <remarks>
    /// Retries go through the generated client's <see cref="RetryConfiguration"/>, which is process-wide: the last
    /// <see cref="CrosslyClient"/> created sets it. The buyer twin is <c>net.crossly.buyer.CrosslyBuyerClient</c>
    /// (same file, other namespace): keep the two in step.
    /// </remarks>
    public sealed class CrosslyClient
    {
        /// <summary>The package version.</summary>
        public static readonly string Version = Configuration.Version;

        /// <summary>User-Agent sent with every request.</summary>
        public static readonly string UserAgent = "crossly-csharp/" + Version;

        private static readonly AsyncLocal<string> NextIdempotencyKey = new AsyncLocal<string>();

        public CrosslyClient(string token) : this(new CrosslyClientOptions { Token = token })
        {
        }

        public CrosslyClient(CrosslyClientOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));
            if (string.IsNullOrWhiteSpace(options.Token))
            {
                throw new ArgumentException(
                    "A Crossly token is required: a Personal Access Token (crossly_pat_..., Settings -> Developer) or a seller OAuth token.",
                    nameof(options));
            }
            Configuration = new Configuration
            {
                BasePath = options.BasePath,
                AccessToken = options.Token.Trim(),
                UserAgent = options.UserAgent == null ? UserAgent : UserAgent + " " + options.UserAgent,
                Timeout = (int)options.Timeout.TotalMilliseconds,
            };
            CrosslyRetryPolicy.Install(options.MaxRetries, options.MaxRetryAfter);
        }

        /// <summary>A client from the CROSSLY_TOKEN environment variable, with the defaults.</summary>
        public static CrosslyClient FromEnvironment() => new CrosslyClient(Environment.GetEnvironmentVariable("CROSSLY_TOKEN"));

        /// <summary>The generated client configuration, for anything this class does not wrap.</summary>
        public Configuration Configuration { get; }

        /// <summary>An API class on this client, whose failures throw <see cref="CrosslyException"/>.</summary>
        public T Api<T>() where T : IApiAccessor
        {
            var api = (T)Activator.CreateInstance(typeof(T), Configuration);
            api.ExceptionFactory = ExceptionFactory;
            return api;
        }

        /// <summary>
        /// Turns a failed response into <see cref="CrosslyException"/> (the generated default returns nothing at all
        /// for a request that got no response).
        /// </summary>
        public static readonly ExceptionFactory ExceptionFactory = (method, response) =>
        {
            var status = (int)response.StatusCode;
            if (status > 0 && status < 400) return null;
            Func<string, string> header = name =>
                response.Headers != null && response.Headers.TryGetValue(name, out var values) ? values.FirstOrDefault() : null;
            Func<string, string> anyCase = name =>
                header(name) ?? (response.Headers?.Keys.FirstOrDefault(k => string.Equals(k, name, StringComparison.OrdinalIgnoreCase)) is string k2 ? header(k2) : null);
            var inner = status == 0 && !string.IsNullOrEmpty(response.ErrorText) ? new WebException(response.ErrorText) : null;
            return CrosslyException.FromResponse(status, response.RawContent, anyCase, inner);
        };

        /// <summary>
        /// Make the POST/PATCH calls made inside the returned scope (this async flow) use <paramref name="key"/> as
        /// their Idempotency-Key, so a retry after a crash cannot create a second order or charge. Without it every
        /// POST/PATCH already gets a fresh key per call.
        /// <code>using (CrosslyClient.UseIdempotencyKey("order-1234")) { await checkout.CreateAsync(...); }</code>
        /// </summary>
        public static IDisposable UseIdempotencyKey(string key)
        {
            var previous = NextIdempotencyKey.Value;
            NextIdempotencyKey.Value = key;
            return new Restore(previous);
        }

        internal static string CurrentIdempotencyKey => NextIdempotencyKey.Value;

        private sealed class Restore : IDisposable
        {
            private readonly string _previous;

            public Restore(string previous) => _previous = previous;

            public void Dispose() => NextIdempotencyKey.Value = _previous;
        }
    }

    /// <summary>
    /// Retry policy for the generated client: a 429, 500, 502, 503 or 504, or a request that got no response, is
    /// retried with exponential backoff and jitter, honouring <c>Retry-After</c>. A POST or PATCH is retried only
    /// with an Idempotency-Key, which <c>ApiClient.InterceptRequest</c> below always adds.
    /// </summary>
    internal static class CrosslyRetryPolicy
    {
        private static readonly int[] Retryable = { 429, 500, 502, 503, 504 };
        private static readonly Random Jitter = new Random();

        internal static void Install(int maxRetries, TimeSpan maxRetryAfter)
        {
            if (maxRetries <= 0)
            {
                RetryConfiguration.RetryPolicy = null;
                RetryConfiguration.AsyncRetryPolicy = null;
                return;
            }
            RetryConfiguration.RetryPolicy = Policy
                .HandleResult<IRestResponse>(r => ShouldRetry(r, maxRetryAfter))
                .WaitAndRetry(maxRetries, (attempt, outcome, context) => Delay(attempt, outcome.Result), (outcome, wait, attempt, context) => { });
            RetryConfiguration.AsyncRetryPolicy = Policy
                .HandleResult<IRestResponse>(r => ShouldRetry(r, maxRetryAfter))
                .WaitAndRetryAsync(maxRetries, (attempt, outcome, context) => Delay(attempt, outcome.Result), (outcome, wait, attempt, context) => Task.CompletedTask);
        }

        private static bool ShouldRetry(IRestResponse r, TimeSpan maxRetryAfter)
        {
            var status = (int)r.StatusCode;
            var transport = status == 0 && r.ResponseStatus != ResponseStatus.Completed;
            if (!transport && Array.IndexOf(Retryable, status) < 0) return false;
            var method = r.Request?.Method;
            if ((method == Method.POST || method == Method.PATCH) && !HasIdempotencyKey(r.Request)) return false;
            var retryAfter = RetryAfterOf(r);
            return retryAfter == null || retryAfter.Value <= maxRetryAfter;
        }

        private static TimeSpan Delay(int attempt, IRestResponse r)
        {
            var retryAfter = r == null ? null : RetryAfterOf(r);
            if (retryAfter != null) return retryAfter.Value;
            var ms = Math.Min(20000.0, 500.0 * Math.Pow(2, attempt - 1));
            double factor;
            lock (Jitter) factor = 0.5 + Jitter.NextDouble() / 2;
            return TimeSpan.FromMilliseconds(ms * factor);
        }

        private static TimeSpan? RetryAfterOf(IRestResponse r)
        {
            var h = r.Headers?.FirstOrDefault(p => string.Equals(p.Name, "Retry-After", StringComparison.OrdinalIgnoreCase));
            return CrosslyRetryAfter.Parse(h?.Value?.ToString(), DateTimeOffset.UtcNow);
        }

        internal static bool HasIdempotencyKey(IRestRequest request) =>
            request != null && request.Parameters.Any(p =>
                p.Type == ParameterType.HttpHeader && string.Equals(p.Name, "Idempotency-Key", StringComparison.OrdinalIgnoreCase));
    }
}

namespace net.crossly.Client
{
    public partial class ApiClient
    {
        // Every POST and PATCH carries an Idempotency-Key: the API replays the first response for a repeated key for
        // 24 hours, which is what makes the retry policy safe for writes (a few money endpoints refuse a write
        // without one). The same request object is re-sent on a retry, so the key stays the same.
        partial void InterceptRequest(IRestRequest request)
        {
            if ((request.Method == RestSharp.Method.POST || request.Method == RestSharp.Method.PATCH) && !CrosslyRetryPolicy.HasIdempotencyKey(request))
            {
                request.AddHeader("Idempotency-Key", CrosslyClient.CurrentIdempotencyKey ?? Guid.NewGuid().ToString());
            }
        }
    }
}
