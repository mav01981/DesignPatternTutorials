using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Facade.Example
{
    public class Subsystem1
    {
       public string RunOperationA()
        {
            return $"{MethodBase.GetCurrentMethod().Name}: Get ready!\n";
        }
        public string RunOperationB()
        {
            return $"{MethodBase.GetCurrentMethod().Name}: Get ready!\n";
        }
        public string RunOperationC()
        {
            return $"{MethodBase.GetCurrentMethod().Name}: Get ready!\n";
        }
        public string RunOperationD()
        {
            return $"{MethodBase.GetCurrentMethod().Name}: Get ready!\n";
        }
        public string RunOperationE()
        {
            return $"{MethodBase.GetCurrentMethod().Name}: Get ready!\n";
        }
    }
}
