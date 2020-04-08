namespace Adapter.Target
{
    // The Target defines the domain-specific interface in use by the Client.
    public interface IVehicleDetailsTarget
    {
        public string GetHistoryForVehicle(string registration);
    }
}
