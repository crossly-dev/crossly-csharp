# Crossly C# / .NET SDK

[![ci](https://github.com/crossly-dev/crossly-csharp/actions/workflows/ci.yml/badge.svg)](https://github.com/crossly-dev/crossly-csharp/actions/workflows/ci.yml) [![release](https://github.com/crossly-dev/crossly-csharp/actions/workflows/release.yml/badge.svg)](https://github.com/crossly-dev/crossly-csharp/actions/workflows/release.yml) [![NuGet](https://img.shields.io/nuget/v/Crossly)](https://www.nuget.org/packages/Crossly) [![license](https://img.shields.io/badge/license-MIT-blue)](LICENSE)

Official C# / .NET clients for the [Crossly](https://crossly.net) API: list once and sell across every marketplace, read
orders, manage inventory, and receive signed webhooks. Generated from the public OpenAPI specs and released
automatically when they change, with signed build provenance.

## Install

| client | for | install |
|---|---|---|
| seller | your store: listings, crossposting, orders, analytics | `dotnet add package Crossly` |
| buyer | shopping: cart, orders, wishlists, offers, cashback | `dotnet add package Crossly.Buyer` |

## Two clients, two credentials

| client | credential |
|---|---|
| seller | a Personal Access Token (`crossly_pat_…`, Settings → Developer) or a seller OAuth token |
| buyer | a buyer OAuth token (`crossly_oat_…`) with `buyer:*` scopes |

They are not interchangeable: a seller token is refused by the buyer API and the reverse, even for the same
Crossly account. A 401 from a call that looks right usually means the other client's token.

## First call

```csharp
using Crossly;
using net.crossly;
using net.crossly.Api;

var crossly = new CrosslyClient(Environment.GetEnvironmentVariable("CROSSLY_TOKEN"));  // crossly_pat_…
var listings = crossly.Api<ListingsApi>();

// One page: every filter is an optional named argument.
var page = await listings.ListListingsAsync(page: 1, limit: 25);

// Every listing, each page fetched as the loop reaches it.
await foreach (var item in CrosslyPages.AllAsync((p, limit) => listings.ListListingsAsync(p, limit), r => r.Data))
{
    Console.WriteLine($"{item.Id} {item.Title} {item.Status}");
}
```

`CrosslyClient` builds the generated `Configuration` (bearer token, `User-Agent: crossly-csharp/<version>`,
timeout) and adds what the generated code lacks: a 429, a 5xx or a request that got no response is retried
with exponential backoff that honours `Retry-After`; every POST and PATCH carries an `Idempotency-Key`, so a
retried write is applied once (`using (CrosslyClient.UseIdempotencyKey(key)) { … }` sets your own).
`CrosslyPages.All` is the synchronous pager. The buyer twin is `net.crossly.buyer.CrosslyBuyerClient`.

List calls return `{ data, pagination }` and page with `page` and `limit`. Money fields named `…_cents` are
integer cents. APIs created with `crossly.Api<T>()` throw `Crossly.CrosslyException` with `Status`, `Code` (the API's `error.code`), `Details`, `RetryAfter` and `CorrelationId` for support, including for a request that got no response (status 0, `network_error`), where the generated default returns null.

## Webhooks

Crossly signs every webhook with `Crossly-Signature: t=<unix>,v1=<hex HMAC-SHA256 of "t.body">`. The verifier
ships in the seller and buyer packages and checks the signature in constant time, rejects a timestamp more than
five minutes old, and returns the parsed event:

```csharp
using Crossly.Webhooks;

// rawBody: the exact bytes received, before any JSON parsing
try
{
    var json = CrosslyWebhooks.Verify(rawBody, request.Headers["Crossly-Signature"], secret);
}
catch (CrosslyWebhooks.VerificationException e)
{
    // e.Reason: malformed_header | bad_signature | timestamp_out_of_tolerance | missing_secret -> answer 400
}
```

The verifier is in `Crossly.Core`, which both clients depend on (and which works on its own).

Verify the raw bytes, not a re-serialised body. `webhooks/` holds the same verifier on its own, with the shared
test vectors every language's port is checked against on each build.

## Webhooks in ASP.NET Core

`dotnet add package Crossly.AspNetCore` (.NET 8+). On a minimal API, an endpoint filter; the handler reads the
verified JSON from the context, and a request that does not verify is answered 400 before it runs:

```csharp
using Crossly.AspNetCore;

app.MapPost("/webhooks/crossly", (HttpContext context) =>
{
    var json = context.GetCrosslyWebhookBody();
    return Results.NoContent();
}).AddCrosslyWebhookVerification(Environment.GetEnvironmentVariable("CROSSLY_WEBHOOK_SECRET"));
```

Or middleware for a path, which rewinds the body so `[FromBody]` binding in controllers still works:
`app.UseCrosslyWebhooks("/webhooks/crossly", secret);`. The client packages do not depend on ASP.NET Core.
Runnable versions are in [examples/](examples).

| package | what |
|---|---|
| `Crossly` | seller client (netstandard2.0) |
| `Crossly.Buyer` | buyer client (netstandard2.0) |
| `Crossly.Core` | webhook verifier, `CrosslyException`, `CrosslyPages`; a dependency of both clients |
| `Crossly.AspNetCore` | webhook middleware and endpoint filter (net8.0) |

## Where things are

| client | API classes | models | API reference pages |
|---|---|---|---|
| seller | `seller/src/net.crossly/Api/` | `seller/src/net.crossly/Model/<Area>/` | `seller/docs/` |
| buyer | `buyer/src/net.crossly.buyer/Api/` | `buyer/src/net.crossly.buyer/Model/<Area>/` | `buyer/docs/` |

One class per API group (`OrdersApi`, `ListingsApi`, …), one model per type, the
models grouped one folder per product area (`vault`, `world`, `order`, …). A type
several endpoints share is ONE model, named after where it first appears
(`GetOrderResponse`, `ListOrdersItem`) or, for small shared shapes such as `{ ok }`,
after its fields (`OkResponse`). Each client README lists every method.

## Versions and changelog

Semantic versioning. While the version is 0.x, a release that removes an operation or a model bumps the minor
version; anything else bumps the patch. Every [CHANGELOG](CHANGELOG.md) entry lists the operations and models
that were added, changed or removed in the specs it was generated from.

## Verifying a release

Every release artifact is built on GitHub-hosted runners by [release.yml](.github/workflows/release.yml) and
carries a signed SLSA provenance attestation:

```sh
gh attestation verify <downloaded-file> --repo crossly-dev/crossly-csharp
```

## Contributing

`seller/`, `buyer/` and `webhooks/` are generated, so a pull request that edits them would be overwritten by the
next release. Open an issue instead: the fix goes into the API spec or the generator, and every language picks it
up. [CONTRIBUTING.md](CONTRIBUTING.md) explains how to regenerate locally.

## More

- API reference and guides: https://crossly.net/docs
- Other languages: https://github.com/crossly-dev
- TypeScript (Node and browsers): [`@crossly/sdk`](https://github.com/crossly-dev/crossly-sdk); command line: [`@crossly/cli`](https://github.com/crossly-dev/crossly-cli); AI agents: [`@crossly/mcp`](https://github.com/crossly-dev/crossly-mcp)

## License

[MIT](LICENSE)
