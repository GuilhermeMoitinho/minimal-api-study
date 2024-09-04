using native_aot.Controllers;
using native_aot.Extensions;
using native_aot.Models;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateSlimBuilder(args);

builder.AddApiConfig()
       .AddInfrastructure();

var app = builder.Build();

app.AddMaps();

app.AddUseApiConfig();

[JsonSerializable(typeof(IList<Peaple>))]
public partial class ResolveJson : JsonSerializerContext
{
}

