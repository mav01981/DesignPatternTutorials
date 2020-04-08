namespace Facade.Example
{
    public class Facade
    {
        protected Subsystem1 _subsystem1;

        protected Subsystem2 _subsystem2;

        public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
        {
            this._subsystem1 = subsystem1;
            this._subsystem2 = subsystem2;
        }

        // The Facade's methods are convenient shortcuts to the sophisticated
        // functionality of the subsystems. However, clients get only to a
        // fraction of a subsystem's capabilities.
        public string Operation()
        {
            string result = "Facade initializes subsystems:\n";
            result += this._subsystem1.RunOperationA();
            result += this._subsystem2.DoProcess1();
            result += "Facade orders subsystems to perform the action:\n";
            result += this._subsystem1.RunOperationC();
            result += this._subsystem2.DoProcess3();
            return result;
        }
    }
}
