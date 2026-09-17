using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace Crossly.Webhooks;

/// <summary>
/// Verify a Crossly webhook.
///
/// <code>
/// Crossly-Signature: t=&lt;unix seconds&gt;,v1=&lt;hex HMAC-SHA256&gt;
/// </code>
///
/// signed over <c>$"{t}.{rawBody}"</c> with the endpoint's signing secret.
///
/// <para>Three ways to get this wrong, all silent:</para>
/// <list type="number">
///   <item>Verifying a re-serialised body. System.Text.Json's round trip
///   reorders nothing but reformats numbers and escaping, so genuine payloads
///   fail and the usual fix is to stop verifying. In ASP.NET Core enable
///   buffering and read the raw stream, or bind to <c>byte[]</c>.</item>
///   <item>Comparing with <c>==</c>. String equality returns early on the first
///   differing char; <see cref="CryptographicOperations.FixedTimeEquals"/> does
///   not.</item>
///   <item>Ignoring the timestamp. Without it a captured request replays
///   forever. The timestamp is INSIDE the signed message, so it cannot be
///   edited to look fresh.</item>
/// </list>
///
/// <para>No package references beyond the BCL. Returns the raw body rather than
/// a deserialised object — this has no opinion about your event types, and
/// picking one would make it un-droppable into half the projects that need
/// it.</para>
/// </summary>
public static class CrosslyWebhooks
{
    public const int DefaultToleranceSeconds = 300;

    /// <summary>Thrown when a webhook does not verify.</summary>
    public sealed class VerificationException : Exception
    {
        /// <summary>malformed_header | bad_signature | timestamp_out_of_tolerance | missing_secret</summary>
        public string Reason { get; }

        public VerificationException(string reason, string message) : base(message) => Reason = reason;
    }

    /// <summary>
    /// Verify a webhook and return the raw body.
    /// </summary>
    /// <param name="rawBody">The EXACT bytes received.</param>
    /// <param name="signatureHeader">The Crossly-Signature header, verbatim.</param>
    /// <param name="secret">The endpoint's signing secret.</param>
    /// <exception cref="VerificationException">
    /// On anything that does not verify. It throws rather than returning false
    /// so a caller who forgets to check a return value does not silently accept
    /// forged events.
    /// </exception>
    public static string Verify(
        byte[] rawBody,
        string? signatureHeader,
        string secret,
        int toleranceSeconds = DefaultToleranceSeconds,
        long? now = null)
    {
        if (string.IsNullOrEmpty(secret))
            throw new VerificationException("missing_secret", "A webhook signing secret is required.");

        if (string.IsNullOrEmpty(signatureHeader))
            throw new VerificationException("malformed_header", "No Crossly-Signature header on the request.");

        long timestamp = 0;
        var haveTimestamp = false;
        string? provided = null;

        // Field-wise rather than one regex, so a future v2= alongside v1= does
        // not break existing verifiers — the entire reason the scheme carries a
        // version.
        foreach (var part in signatureHeader.Split(','))
        {
            var eq = part.IndexOf('=');
            if (eq < 0) continue;

            var key = part[..eq].Trim();
            var value = part[(eq + 1)..].Trim();

            if (key == "t")
            {
                // InvariantCulture: a machine running under a locale with a
                // different digit separator must still read a unix timestamp.
                if (!long.TryParse(value, NumberStyles.None, CultureInfo.InvariantCulture, out timestamp))
                {
                    throw new VerificationException(
                        "malformed_header", "Crossly-Signature carries a non-numeric timestamp.");
                }
                haveTimestamp = true;
            }
            else if (key == "v1")
            {
                provided = value;
            }
        }

        if (!haveTimestamp || string.IsNullOrEmpty(provided))
        {
            var preview = signatureHeader.Length > 60 ? signatureHeader[..60] : signatureHeader;
            throw new VerificationException(
                "malformed_header",
                $"Could not parse Crossly-Signature: expected \"t=<unix>,v1=<hex>\", got \"{preview}\".");
        }

        var body = Encoding.UTF8.GetString(rawBody);
        var expected = HmacHex(secret, $"{timestamp}.{body}");

        // FixedTimeEquals is the BCL's constant-time compare. It returns false
        // on a length mismatch rather than throwing, which a truncated
        // signature produces.
        if (!CryptographicOperations.FixedTimeEquals(
                Encoding.UTF8.GetBytes(expected), Encoding.UTF8.GetBytes(provided)))
        {
            throw new VerificationException(
                "bad_signature",
                "Signature did not match. If genuine payloads are failing, you are almost certainly "
                + "verifying a re-serialised body — pass the bytes you read off the wire.");
        }

        // Freshness AFTER the signature, so an attacker learns nothing about
        // timestamps without already holding a valid signature.
        var current = now ?? DateTimeOffset.UtcNow.ToUnixTimeSeconds();
        var drift = Math.Abs(current - timestamp);
        if (drift > toleranceSeconds)
        {
            throw new VerificationException(
                "timestamp_out_of_tolerance",
                $"Timestamp is {drift}s away from now (tolerance {toleranceSeconds}s). "
                + "This is a replay guard — if it fires on live traffic, check your server clock.");
        }

        return body;
    }

    private static string HmacHex(string secret, string message)
    {
        using var mac = new HMACSHA256(Encoding.UTF8.GetBytes(secret));
        var digest = mac.ComputeHash(Encoding.UTF8.GetBytes(message));
        return Convert.ToHexString(digest).ToLowerInvariant();
    }
}
