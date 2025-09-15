using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class BaseDecorator : HotelBilling
    {
        private HotelBilling instance;

        public BaseDecorator(HotelBilling h)
        {
            instance = h;
        }

        public virtual double getCost()
        {
            return instance.getCost();
        }
    }
}
