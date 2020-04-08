using System.Reflection;

namespace Facade.Example
{
    public class Subsystem2
    {
        public string DoProcess1()
        {
            return $"{MethodBase.GetCurrentMethod().Name}: Get ready!\n";
        }
        public string DoProcess2()
        {
            return $"{MethodBase.GetCurrentMethod().Name}: Get ready!\n";
        }
        public string DoProcess3()
        {
            return $"{MethodBase.GetCurrentMethod().Name}: Get ready!\n";
        }
    }
}
