using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorRight
{
    internal class StandardRoom : HotelBilling
    {
        public string Discription()
        {
            return "Standard";
        }

        public double getCost()
        {
            return 15000.00;
        }
    }
}
