using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorRight
{
    internal class Airport : BaseDecorator
    {
        private double airport;

        public Airport(HotelBilling hotel, double airport) : base(hotel) 
        {
            this.airport = airport;
        }

        public override string Discription()
        {
            return hotel.Discription() + "Airport";
        }

        public override double getCost()
        {
            return hotel.getCost() + airport;
        }
    }
}
