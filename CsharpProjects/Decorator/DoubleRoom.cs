using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class DoubleRoom : HotelBilling
    {
        public double getCost()
        {
            return 22000.00;
        }
    }
}
