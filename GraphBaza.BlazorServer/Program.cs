

using GraphBaza.BlazorServer.Components;
using GraphBaza.Core.Queries;
using HotChocolate.AspNetCore;
using Microsoft.AspNetCore.Components.Endpoints;
using Microsoft.AspNetCore.Antiforgery;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddRazorComponents()
    .AddInteractiveServerComponents()

    ;

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>();

var app = builder.Build();

//app.UseHttpsRedirection();
//app.MapStaticAssets();
app.UseStaticFiles();
app.MapRazorComponents<App>().AddInteractiveServerRenderMode();
app.UseRouting();
app.UseAntiforgery();

app.UseEndpoints(endpoints =>
{

    endpoints.MapRazorComponents<App>()
        .AddInteractiveServerRenderMode();
    
    endpoints.MapGraphQL();
    
    //endpoints.MapGet("/api", async context =>
    //{	await context.Response.WriteAsync("Say Hello to QiMono !!! \n Use /graphql for API endpoint");});
});

if (!app.Environment.IsDevelopment())
{

    app.UseDeveloperExceptionPage();
    //app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.Run();
