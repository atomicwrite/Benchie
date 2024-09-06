var builder = WebApplication.CreateBuilder(args);

 
var app = builder.Build();

 
//app.UseHttpsRedirection();
const string helloWorld = "Hello world";

app.MapGet("/helloworld", () => helloWorld)
    .WithName("HelloWorld");
    //.WithOpenApi();

app.Run();