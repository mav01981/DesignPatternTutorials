using AbstractFactory.ConcretFactory;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // The AbstractFactory declares an interface for operations which will create AbstractProduct objects.
            // The ConcreteFactory objects implement the operations defined by the AbstractFactory.
            // The AbstractProduct declares an interface for a type of product.
            // The Products define a product object that will be created by the corresponding ConcreteFactory.
            // The Client uses the AbstractFactory and AbstractProduct interfaces.

            Console.WriteLine("Select Factory ..");
            char input = Console.ReadKey().KeyChar;

            AbstractVehiclefactory factory = input switch
            {
                'S' => new SuzukiFactory(),
                'V' => new VauxhallFactory(),
                _ => throw new ArgumentNullException(nameof(input))
            };

            Console.Clear();

            var car = factory.CreateCar();
            var van = factory.CreateVan();

            Console.WriteLine($"{factory.GetType().Name} Factory produces car: { car.GetType().Name}");
            Console.WriteLine($"{factory.GetType().Name} Factory produces van: { van.GetType().Name}");

            Console.ReadKey();
        }
    }
}
