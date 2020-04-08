using Adapter.Adaptee;
using Adapter.Target;
using System.Text;

namespace Adapter.Adapter
{
    public class Vehicle : IVehicleDetails
    {
        private TrafficHistory _trafficHistory;
        public Vehicle(TrafficHistory trafficHistory)
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
