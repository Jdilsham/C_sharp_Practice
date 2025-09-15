using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorRight
{
    internal class Dining : BaseDecorator
    {
        private double dining;

        public Dining(HotelBilling hotel, double dining) : base(hotel)
        {
            this.dining = dining;
        }

        public override string Discription()
        {
            return hotel.Discription() + "Dining";
        }

        public override double getCost()
        {
            return hotel.getCost() + dining + serviceCharge();
        }

        public double serviceCharge()
        {
            return dining * 0.1;
        }
    }
}
