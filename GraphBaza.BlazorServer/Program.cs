

using GraphBaza.BlazorServer.Components;
using GraphBaza.Core.Queries;
using HotChocolate.AspNetCore;
using Microsoft.AspNetCore.Components.Endpoints;
using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.HttpOverrides;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.Configure<ForwardedHeadersOptions>(options => {
    options.ForwardedHeaders = ForwardedHeaders.All;
    options.KnownNetworks.Clear();
    options.KnownProxies.Clear();
});

builder.Services.AddGraphQLServer().AddQueryType<Query>();

builder.Logging.AddConsole();
builder.Logging.SetMinimumLevel(LogLevel.Debug);

var app = builder.Build();

app.UseForwardedHeaders();
app.UseStaticFiles();
app.UseRouting();
app.UseAntiforgery();

app.MapBlazorHub();  
app.MapGraphQL(); 

//app.MapFallbackToPage("/_Host");
app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.Run();
