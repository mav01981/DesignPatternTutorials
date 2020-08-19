
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
            ILogger logger = loggerFactory.CreateLogger<Program>();

            var userList = new List<User>
            {
                new User(logger, "John"),
                new User(logger, "James"),
                new User(logger, "David"),
                new User(logger, "Tom")
            };

            new ConcreteMediator(userList);

            var John = userList.FirstOrDefault(x => x.Name == "John");
            John.Greet();

            Console.Read();

            // Output
            // John Greets hello
            // John responds hello
            // James responds hello
            // David responds hello
            // Tom responds hello
        }
    }
}
