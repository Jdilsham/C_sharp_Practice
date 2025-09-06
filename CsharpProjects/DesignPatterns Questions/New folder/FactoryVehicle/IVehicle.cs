using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryVehicle
{
    public interface IVehicle
    {
        int NumberOfWheel();
        string VehicleType();
    }
}
