using Builder.Example;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
            ILogger logger = loggerFactory.CreateLogger<Program>();

            var products = new List<Product>
            {
                new Product { Name = "Monitor", Price = 200.50 },
                new Product { Name = "Mouse", Price = 20.41 },
                new Product { Name = "Keyboard", Price = 30.15}
            };

            var builder = new ProductStockReportBuilder(products);
            var director = new ProductStockReportDirector(builder);
            director.BuildStockReport();

            var report = builder.GetReport();
            logger.LogInformation(report);

            Console.Read();

            //Output
            //STOCK REPORT FOR ALL THE PRODUCTS ON DATE: 19/08/2020 16:22:20
            //
            //Product name: Monitor, product price: 200.5
            //Product name: Mouse, product price: 20.41
            //Product name: Keyboard, product price: 30.15
            //
            //Report provided by the IT_PRODUCTS company.
        }
    }
}
