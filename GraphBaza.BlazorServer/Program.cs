

using GraphBaza.BlazorServer.Components;
using GraphBaza.Core.Queries;
using HotChocolate.AspNetCore;
using Microsoft.AspNetCore.Components.Endpoints;
using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.HttpOverrides;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddRazorComponents()
    .AddInteractiveServerComponents()
    ;
builder.Services.Configure<ForwardedHeadersOptions>(options => {
    options.ForwardedHeaders = 
        ForwardedHeaders.XForwardedFor | 
        ForwardedHeaders.XForwardedProto;
});

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>();

var app = builder.Build();

app.UseForwardedHeaders();
//app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAntiforgery();

//app.UseEndpoints(endpoints =>{

    //endpoints.MapRazorComponents<App>().AddInteractiveServerRenderMode();
    
    //endpoints.MapGraphQL();
    
    //endpoints.MapGet("/api", async context =>
    //{	await context.Response.WriteAsync("Say Hello to QiMono !!! \n Use /graphql for API endpoint");});
//});

if (!app.Environment.IsDevelopment())
{

    app.UseDeveloperExceptionPage();
    app.UseHsts();
}
app.MapBlazorHub();
app.MapGraphQL();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
//.AddAdditionalAssemblies(typeof(GraphBaza.BlazorServer.Components.Pages.Home).Assembly)
    ;

app.Run();
