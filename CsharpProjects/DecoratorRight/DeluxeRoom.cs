using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorRight
{
    internal class DeluxeRoom : HotelBilling
    {
        public string Discription()
        {
            return "Deluxe";
        }

        public double getCost()
        {
            return 30000.00;
        }
    }
}
