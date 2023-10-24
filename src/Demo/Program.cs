
using Leonardo;

using var context = new FibonacciDataContext();

var results = new Fibonacci(context).RunAsync(args);

Console.WriteLine($"Result: {string.Join(", ", results.Result)}");
results.Wait();
