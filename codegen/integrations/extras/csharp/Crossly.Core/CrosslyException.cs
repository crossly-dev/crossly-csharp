using System;
using System.Globalization;
using Newtonsoft.Json.Linq;

namespace Crossly
{
    /// <summary>
    /// A failed Crossly API call, read from the API's error envelope
    /// <c>{ "error": { "code", "message", "details" }, "correlationId" }</c>.
    /// </summary>
    /// <remarks>
    /// <see cref="Code"/> is the stable machine code to branch on (<c>validation_error</c>, <c>not_found</c>,
    /// <c>rate_limited</c>, ...); <see cref="CorrelationId"/> is what Crossly support needs to find the request. A
    /// request that never got a response (DNS, TLS, a timeout after every retry) has <see cref="Status"/> 0 and code
    /// <c>network_error</c>.
    /// </remarks>
    public class CrosslyException : Exception
    {
        public CrosslyException(
            int status,
            string code,
            string message,
            JToken? details = null,
            string? correlationId = null,
            TimeSpan? retryAfter = null,
            string? responseBody = null,
            Exception? inner = null)
            : base(message, inner)
        {
            Status = status;
            Code = code;
            Details = details;
            CorrelationId = correlationId;
            RetryAfter = retryAfter;
            ResponseBody = responseBody;
        }

        /// <summary>HTTP status, or 0 when no response arrived.</summary>
        public int Status { get; }

        /// <summary>The API's machine-readable error code, e.g. <c>validation_error</c>.</summary>
        public string Code { get; }

        /// <summary><c>error.details</c> from the envelope (field errors, limits, ...), or null.</summary>
        public JToken? Details { get; }

        /// <summary>Quote this to Crossly support; it threads the request through the server logs.</summary>
        public string? CorrelationId { get; }

        /// <summary>How long the API asked to wait (429 / 503), or null.</summary>
        public TimeSpan? RetryAfter { get; }

        /// <summary>The raw response body, or null.</summary>
        public string? ResponseBody { get; }

        /// <summary>Build one from an HTTP status, the body, and a header lookup (any of them may be null).</summary>
        public static CrosslyException FromResponse(int status, string? body, Func<string, string?>? header, Exception? inner = null)
        {
            var code = status == 0 ? "network_error" : "http_" + status.ToString(CultureInfo.InvariantCulture);
            string? message = null;
            JToken? details = null;
            var correlationId = header?.Invoke("x-correlation-id");
            if (!string.IsNullOrEmpty(body))
            {
                try
                {
                    if (JToken.Parse(body!) is JObject root)
                    {
                        if (root["correlationId"] is JValue cid && cid.Type == JTokenType.String) correlationId = (string?)cid;
                        var error = root["error"];
                        if (error is JObject e)
                        {
                            if (e["code"] is JValue c && c.Type == JTokenType.String) code = (string)c!;
                            if (e["message"] is JValue m && m.Type == JTokenType.String) message = (string?)m;
                            if (e["details"] is JToken d && d.Type != JTokenType.Null) details = d;
                        }
                        else if (error is JValue s && s.Type == JTokenType.String)
                        {
                            message = (string?)s;
                        }
                    }
                }
                catch (Newtonsoft.Json.JsonException)
                {
                    message = body!.Length > 300 ? body.Substring(0, 300) : body;
                }
            }
            message ??= status == 0 ? inner?.Message ?? "request failed" : "HTTP " + status.ToString(CultureInfo.InvariantCulture);
            var retryAfter = CrosslyRetryAfter.Parse(header?.Invoke("retry-after"), DateTimeOffset.UtcNow);
            var full = code + ": " + message
                + (status > 0 ? " (HTTP " + status.ToString(CultureInfo.InvariantCulture) + ")" : "")
                + (correlationId != null ? " [correlationId " + correlationId + "]" : "");
            return new CrosslyException(status, code, full, details, correlationId, retryAfter, body, inner);
        }
    }

    /// <summary>The <c>Retry-After</c> header: delta-seconds or an HTTP date (RFC 9110).</summary>
    public static class CrosslyRetryAfter
    {
        /// <summary>The wait it asks for, or null when absent or unreadable.</summary>
        public static TimeSpan? Parse(string? value, DateTimeOffset now)
        {
            if (string.IsNullOrWhiteSpace(value)) return null;
            var v = value!.Trim();
            if (double.TryParse(v, NumberStyles.Float, CultureInfo.InvariantCulture, out var seconds))
            {
                if (double.IsNaN(seconds) || seconds < 0) return null;
                return TimeSpan.FromSeconds(Math.Min(seconds, 365 * 24 * 3600.0));
            }
            if (DateTimeOffset.TryParseExact(v, "r", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal, out var at))
            {
                var wait = at - now;
                return wait < TimeSpan.Zero ? TimeSpan.Zero : wait;
            }
            return null;
        }
    }
}
