using System;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Downloading data...");

        Task<string> api1 = CallApi("Users", 2000);
        Task<string> api2 = CallApi("Products", 3000);

        string[] results = await Task.WhenAll(api1, api2);

        Console.WriteLine($" {results[0]}");
        Console.WriteLine($" {results[1]}");

    }

    static async Task<string> CallApi(string apiName, int delay)
    {
        Console.WriteLine($"Call API {apiName}...");
        await Task.Delay(delay);
        return $"Response from {apiName}";

    }

}
