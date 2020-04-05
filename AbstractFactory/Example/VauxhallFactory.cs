using AbstractFactory.AbstractProducts;
using AbstractFactory.ConcreteProducts;

namespace AbstractFactory.ConcretFactory
{
    class VauxhallFactory : AbstractVehiclefactory
    {
        public override MotorBike CreateBike()
        {
            return new Ducati();
        }

        public override Car CreateCar()
        {
            return new Capri();
        }

        public override Van CreateVan()
        {
            return new FordTransit();
        }
    }
}
