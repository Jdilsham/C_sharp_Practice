using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryVehicle
{
    internal class Car : IVehicle
    {
        public int NumberOfWheel()
        {
            return 4;
        }

        public string VehicleType()
        {
            return "Car";
        }
    }
}
