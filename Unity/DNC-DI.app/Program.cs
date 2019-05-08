using DNC_DI.app.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DNC_DI.app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            new Boostrapper().Run();


        }
    }
}
