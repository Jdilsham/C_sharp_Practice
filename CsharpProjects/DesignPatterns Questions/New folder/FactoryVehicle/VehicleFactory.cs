using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryVehicle
{
    internal class VehicleFactory
    {
        public IVehicle getvehicle(string type)
        {

            if (string.IsNullOrEmpty(type))
            {
                return null;
            }

            string Type = type.ToUpper();

            if (Type == "BYKE")
            {
                return new Byke();
            }

            if (Type == "CAR")
            {
                return new Car();
            }

            if (Type == "RICKSHAW")
            {
                return new Rickshaw();
            }

            return null;
        }
    }
}
