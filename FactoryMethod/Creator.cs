using System;
using System.Collections.Generic;
using System.Text;

namespace CarFactory
{
    /// <summary>
    /// Creator.
    /// </summary>
    abstract class Creator
    {
        private List<CarParts> _parts = new List<CarParts>();

        //Factory method
        public abstract void CreateCars();

        public List<CarParts> Parts
        {
            get { return _parts; }
        }
    }
}
