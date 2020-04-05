using AbstractFactory.ConcretFactory;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //The AbstractFactory declares an interface for operations which will create AbstractProduct objects.
            //The ConcreteFactory objects implement the operations defined by the AbstractFactory.
            //The AbstractProduct declares an interface for a type of product.
            //The Products define a product object that will be created by the corresponding ConcreteFactory.
            //The Client uses the AbstractFactory and AbstractProduct interfaces.

            Console.WriteLine("Select Factory ..");
            char input = Console.ReadKey().KeyChar;
            AbstractVehiclefactory factory;
            switch (input)
            {
                case 'S':
                    factory = new SuzukiFactory();
                    break;

                case 'V':
                    factory = new VauxhallFactory();
                    break;

                default:
                    throw new NotImplementedException();

            }

            var car = factory.CreateCar();
            var van = factory.CreateVan();

            Console.WriteLine("Susuki Factory produces car: " + car.GetType().Name);
            Console.WriteLine("Susuki Factory produces van: " + van.GetType().Name);

            Console.ReadKey();
        }
    }
}
