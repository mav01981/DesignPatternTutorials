using Command.Example;
using Microsoft.Extensions.Logging;
using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
            ILogger logger = loggerFactory.CreateLogger<Program>();

            Invoker invoker = new Invoker(logger);
            var reciever = new Receiver(logger);
            invoker.SetOnStart(new SimpleCommand(logger, reciever, "Execute Command."));
            invoker.DoWork();

            Console.Read();
        }
    }
}
