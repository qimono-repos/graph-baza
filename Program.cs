


//using graph-baza.Schema;
//namespace graph_baza
//{//
//    public class Query
//    {
//	public string Welcome => "Say hello to QiMono !!!";
//    }

//    public class Program {
var builder = WebApplication.CreateBuilder(args);

Console.WriteLine("Add services to the container.");
Console.WriteLine("Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi");

//builder.Services.AddOpenApi();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddGraphQLServer();//.AddQueryType<Query>();

var app = builder.Build();

Console.WriteLine("Configure the HTTP request pipeline.");

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseDeveloperExceptionPage();
    //app.MapGraphQL("/graphql");
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

//    }
//}
