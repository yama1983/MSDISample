using System;
using Microsoft.Extensions.DependencyInjection;

namespace Sample.App.Console
{
    class Program
    {
        private static IServiceProvider ServiceProvider { get; }

        static Program()
            => ServiceProvider = ConfigureService.Configure();

        static void Main(string[] args)
        {
            var service1 = ServiceProvider.GetRequiredService<ISampleService>();
            service1.AddNumber();

            System.Console.WriteLine($"Integer => {service1.GetResult()}");

            var service2 = ServiceProvider.GetRequiredService<ISampleService>();
            service2.AddNumber();

            System.Console.WriteLine($"Integer => {service2.GetResult()}");
        }
    }
}
