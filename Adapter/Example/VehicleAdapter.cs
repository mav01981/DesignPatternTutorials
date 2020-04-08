using Adapter.Adaptee;
using Adapter.Target;
using System.Text;

namespace Adapter.Adapter
{
    public class VehicleAdapter : IVehicleDetailsTarget
    {
        private TrafficHistoryAdaptee _trafficHistory;
        public VehicleAdapter(TrafficHistoryAdaptee trafficHistory)
        {
            this._trafficHistory = trafficHistory;
        }

        public string GetHistoryForVehicle(string registration)
        {
            var history = _trafficHistory.GetHistory(registration);

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var record in history)
            {
                stringBuilder.AppendLine($"{record.Registration}");
            }

            return stringBuilder.ToString();
        }
    }
}
