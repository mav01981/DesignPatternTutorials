
using AbstractFactory.AbstractProducts;
/// <summary>
/// The AbstractFactory class, which defines methods for creating abstract objects.
/// </summary>
abstract class AbstractVehiclefactory
{
    public abstract Car CreateCar();
    public abstract MotorBike CreateBike();
    public abstract Van CreateVan();
}
