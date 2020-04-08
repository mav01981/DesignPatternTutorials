namespace Adapter.Target
{
    // The Target defines the domain-specific interface in use by the Client.
    public interface IVehicleDetails
    {
        public string GetHistoryForVehicle(string registration);
    }
}
