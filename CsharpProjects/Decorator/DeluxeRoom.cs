using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class DeluxeRoom : HotelBilling
    {
        public double getCost()
        {
            return 30000.00;
        }
    }
}
