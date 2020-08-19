using Microsoft.Extensions.Logging;
using Strategy.Example;
using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
            ILogger logger = loggerFactory.CreateLogger<Program>();

            //Execute concrete Strategy, can be used with the creational factory pattern.
            logger.LogInformation(Translator.Translate("Hello", new EnglishTranslator()));
            logger.LogInformation(Translator.Translate("Hello", new FrenchTranslator()));
            logger.LogInformation(Translator.Translate("Hello", new GermanTranslator()));
            logger.LogInformation(Translator.Translate("Hello", new SpanishTranslator()));

            Console.Read();
        }
    }
}
