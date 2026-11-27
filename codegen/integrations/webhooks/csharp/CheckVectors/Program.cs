// Runs the shared conformance vectors against the C# port.
//
//   dotnet run --project CheckVectors     (from integrations/webhooks/csharp)
//
// Reads the JSON with System.Text.Json, which ships with .NET; any other throw than the port's own
// VerificationException is itself a conformance failure.
using System;
using System.IO;
using System.Text;
using System.Text.Json;
using Crossly.Webhooks;

var path = Path.Combine("..", "test-vectors.json");
using var doc = JsonDocument.Parse(File.ReadAllText(path, Encoding.UTF8));
var tolerance = doc.RootElement.GetProperty("toleranceSeconds").GetInt32();
int ok = 0, bad = 0, total = 0;
foreach (var v in doc.RootElement.GetProperty("vectors").EnumerateArray())
{
    total++;
    var name = v.GetProperty("name").GetString();
    var expect = v.GetProperty("expect").GetString();
    var body = Encoding.UTF8.GetBytes(v.GetProperty("body").GetString() ?? "");
    string got;
    try
    {
        CrosslyWebhooks.Verify(
            body,
            v.GetProperty("header").GetString(),
            v.GetProperty("secret").GetString() ?? "",
            tolerance,
            v.GetProperty("now").GetInt64());
        got = "ok";
    }
    catch (CrosslyWebhooks.VerificationException e)
    {
        got = e.Reason;
    }
    catch (Exception e)
    {
        got = "threw:" + e.GetType().Name;
    }
    if (got == expect)
    {
        ok++;
    }
    else
    {
        bad++;
        Console.WriteLine($"  MISMATCH {name}: expected {expect}, got {got}");
    }
}
Console.WriteLine($"  csharp: {ok}/{total} vectors agree");
return bad > 0 || total == 0 ? 1 : 0;
