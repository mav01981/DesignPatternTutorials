
using AbstractFactory.AbstractProducts;
using AbstractFactory.ConcreteProducts;

namespace AbstractFactory.ConcretFactory
{
    class SuzukiFactory : AbstractVehiclefactory
    {
        public override MotorBike CreateBike()
        {
            return new VStrom();
        }

        public override Car CreateCar()
        {
            return new Swift();
        }

        public override Van CreateVan()
        {
            return new Carry();
        }
    }
}
