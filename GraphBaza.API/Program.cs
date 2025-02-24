

using GraphBaza.Core.Queries;
using HotChocolate.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

Console.WriteLine("Add services to the container.");
Console.WriteLine("Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi");


//builder.Services.AddEndpointsApiExplorer();

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    ;

var app = builder.Build();

app.UseRouting();

Console.WriteLine("Configure Middleware:  HTTP request pipeline.");

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/", async context =>
    {
	await context.Response.WriteAsync("Say Hello to QiMono !!! \n iUse /graphql for API endpoint");
    });
    endpoints.MapGraphQL();
});
	

if (app.Environment.IsDevelopment())
{
    //app.MapOpenApi();
    //app.UseGraphQLPlayground();
    app.UseDeveloperExceptionPage();
}
app.Run();
