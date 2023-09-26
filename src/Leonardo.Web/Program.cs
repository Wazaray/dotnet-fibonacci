var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/fibonacci", 
    async () => await Leonardo.Fibonacci.RunAsync(new []{"44", "43"}));

app.MapGet("/fibonacci/{number}", 
    async (int number) => await Leonardo.Fibonacci.RunAsync(new []{number.ToString()}));

app.Run();