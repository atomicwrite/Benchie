var builder = WebApplication.CreateBuilder(args);

 
var app = builder.Build();

 
app.UseHttpsRedirection();

app.MapGet("/helloworld", () => { return "Hello world"; })
    .WithName("HelloWorld")
    .WithOpenApi();

app.Run();