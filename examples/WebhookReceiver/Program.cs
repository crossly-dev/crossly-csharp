// A Crossly webhook receiver on ASP.NET Core: the signature is verified over the raw body before the handler runs,
// and anything that does not verify is answered 400.
//
//   dotnet add package Crossly.AspNetCore
//   CROSSLY_WEBHOOK_SECRET=... dotnet run      # Settings -> Webhooks; point the endpoint at https://<host>/webhooks/crossly
using Crossly.AspNetCore;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var secret = Environment.GetEnvironmentVariable("CROSSLY_WEBHOOK_SECRET") ?? "";

// Minimal API: an endpoint filter. The handler takes HttpContext and must not bind the body itself.
app.MapPost("/webhooks/crossly", (HttpContext context) =>
{
    var json = context.GetCrosslyWebhookBody();  // the verified JSON: {"id","type","created","data"}
    Console.WriteLine(json);
    // Answer fast; do slow work after replying, or Crossly retries the delivery.
    return Results.NoContent();
}).AddCrosslyWebhookVerification(secret);

// Or middleware for a path, which keeps [FromBody] binding working in controllers:
//   app.UseCrosslyWebhooks("/webhooks/crossly", secret);

app.Run();
