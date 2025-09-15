using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorRight
{
    internal class BaseDecorator : HotelBilling
    {
        public HotelBilling hotel;

        public BaseDecorator(HotelBilling hotel)
        {
            this.hotel = hotel;
        }

        public virtual string Discription()
        {
            return hotel.Discription();
        }

        public virtual double getCost()
        {
            return hotel.getCost();
        }
    }
}
