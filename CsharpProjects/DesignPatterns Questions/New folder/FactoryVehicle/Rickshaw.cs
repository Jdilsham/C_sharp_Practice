using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryVehicle
{
    internal class Rickshaw : IVehicle
    {
        public int NumberOfWheel()
        {
            return 0;
        }
        public string VehicleType()
        {
            return "Rickshaw";
        }
    }
}
