using Adapter.Adaptee;
using Adapter.Adapter;
using Adapter.Target;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Target defines the domain - specific interface in use by the Client.
            // The Client collaborates with objects which conform to the Target.
            // The Adapter adapts the Adaptee to the Target.
            // The Adaptee is the interface that needs adapting(i.e.the one that cannot be refactored).

            var traffic = new TrafficHistoryAdaptee(); 
            IVehicleDetailsTarget target = new VehicleAdapter(traffic); 

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            Console.WriteLine(target.GetHistoryForVehicle(""));

        }
    }
}
