using Adapter.Example;
using System.Collections.Generic;

namespace Adapter.Adaptee
{
    /// <summary>
    /// Adaptee class that cannot be changed.
    /// </summary>
    public class TrafficHistoryAdaptee
    {
        public TrafficHistoryAdaptee() { }

        public List<VehicleModel> GetHistory(string registration)
        {
            return new List<VehicleModel>();
        }
    }
}
