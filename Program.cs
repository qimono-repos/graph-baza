

using GraphBaza;

var builder = WebApplication.CreateBuilder(args);

Console.WriteLine("Add services to the container.");
Console.WriteLine("Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi");

//builder.Services.AddOpenApi();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddGraphQLServer().AddQueryType<Query>();

var app = builder.Build();

Console.WriteLine("Configure the HTTP request pipeline.");

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseDeveloperExceptionPage();
}

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/", async context =>
    {
	await context.Response.WriteAsync("Say Hello to QiMono !!! \n ");
    });
    endpoints.MapGraphQL("/graphql");
});

//app.UseHttpsRedirection();

app.Run();

