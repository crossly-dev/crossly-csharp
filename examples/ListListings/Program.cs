// Print every listing in your Crossly store; pages are fetched as the loop reaches them.
//
//   dotnet add package Crossly
//   CROSSLY_TOKEN=crossly_pat_... dotnet run
using Crossly;
using net.crossly;
using net.crossly.Api;

var crossly = new CrosslyClient(Environment.GetEnvironmentVariable("CROSSLY_TOKEN"));
var listings = crossly.Api<ListingsApi>();

try
{
    // One page, the plain generated call (every filter is an optional named argument).
    var first = await listings.ListListingsAsync(page: 1, limit: 25);
    Console.WriteLine($"first page: {first.Data.Count} listings");

    // Every page, lazily.
    await foreach (var item in CrosslyPages.AllAsync((page, limit) => listings.ListListingsAsync(page, limit), r => r.Data))
    {
        Console.WriteLine($"{item.Id}  {item.Status}  {item.Title}");
    }
}
catch (CrosslyException e)
{
    // e.Code is the API's machine code; quote e.CorrelationId to support.
    Console.Error.WriteLine($"{e.Status} {e.Code} {e.Message} {e.CorrelationId}");
    return 1;
}
return 0;
