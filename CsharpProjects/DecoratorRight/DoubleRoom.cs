using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorRight
{
    internal class DoubleRoom : HotelBilling
    {
        public string Discription()
        {
            return "Double";
        }

        public double getCost()
        {
            return 22000.00;
        }
    }
}
