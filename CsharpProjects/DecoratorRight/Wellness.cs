using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorRight
{
    internal class Wellness : BaseDecorator
    {
        private double wellness;

        public Wellness(HotelBilling hotel, double wellness) : base(hotel)
        {
            this.wellness = wellness;
        }

        public override string Discription()
        {
            return hotel.Discription() + "Wellness";
        }

        public override double getCost()
        {
            return hotel.getCost() + wellness;
        }
    }
}
