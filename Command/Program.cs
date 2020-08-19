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
            invoker.SetOnStart(new SimpleCommand(logger, reciever, "Start Execute Command."));
            invoker.SetOnFinish(new SimpleCommand(logger, reciever, "Finish Execute Command."));
            invoker.DoWork();

            Console.Read();

            //Output
            //Invoker: Executing Commands on Start
            //SimpleCommand: Start Execute Command.
            //Receiver: Email Sent.
            //Receiver: Report Created.
            //Invoker: Executing Commands on Finish
            //SimpleCommand: Finish Execute Command.
            //Receiver: Email Sent.
            //Receiver: Report Created.
        }
    }
}
