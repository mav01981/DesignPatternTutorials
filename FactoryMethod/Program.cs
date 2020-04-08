namespace CarFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Product defines the interfaces of objects that the factory method will create.
            // The ConcreteProduct objects implement the Product interface.
            // The Creator declares the factory method, which returns an object of type Product.The Creator can also define a default implementation of the factory method, though we will not see that in the below example.
            // The ConcreteCreator objects overrides the factory method to return an instance of a Concrete Product.

            var mini = new Mini();
        }
    }
}
