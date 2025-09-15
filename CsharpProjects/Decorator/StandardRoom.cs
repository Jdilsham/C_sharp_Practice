using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class StandardRoom : HotelBilling
    {
        public double getCost()
        {
            return 15000.00;
        }
    }
}
