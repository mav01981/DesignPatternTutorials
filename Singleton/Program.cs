using Microsoft.Extensions.Logging;
using Singleton.Example;
using System;
using System.Threading;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
            ILogger logger = loggerFactory.CreateLogger<Program>();

            Thread process1 = new Thread(() =>
            {
                TestSingleton(logger, new Settings
                {
                    DatabaseConnectionString = "Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;",
                    ProcessFolder = "c:/processFolder",
                    SaveFolder = "c:/saveFolder"
                });
            });
            Thread process2 = new Thread(() =>
            {
                TestSingleton(logger, new Settings
                {
                    DatabaseConnectionString = "Server=myServerAddress2;Database=myDataBase2;Trusted_Connection=True;",
                    ProcessFolder = "c:/processFolder2",
                    SaveFolder = "c:/saveFolder2"
                });
            });

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();

            Console.Read();

            //Output.
            //Server = myServerAddress; Database = myDataBase; Trusted_Connection = True;
            //c:/ processFolder
            //c:/ saveFolder

            //Server = myServerAddress; Database = myDataBase; Trusted_Connection = True;
            //c:/ processFolder
            //c:/ saveFolder
        }

        private static void TestSingleton(ILogger logger, Settings value)
        {
            Singleton singleton = Singleton.GetInstance(value);

            logger.LogInformation($"{singleton.Value}");
        }
    }
}