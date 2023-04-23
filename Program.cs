// See https://aka.ms/new-console-template for more information

// https://learn.microsoft.com/en-us/dotnet/core/docker/build-container?tabs=windows

Console.WriteLine("Hello, World!");

var counter = 0;
var max = args.Length is not 0 ? Convert.ToInt32(args[0]) : -1;
while (max is -1 || counter < max)
{
    Console.WriteLine($"Counter: {++counter}");
    await Task.Delay(TimeSpan.FromMilliseconds(1_000));
}
