using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryVehicle
{
    internal class Byke : IVehicle
    {
        public int NumberOfWheel()
        {
            return 2;
        }

        public string VehicleType()
        {
            return "Byke";
        }
    }
}
