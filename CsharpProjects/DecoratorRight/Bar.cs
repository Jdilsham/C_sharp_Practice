using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorRight
{
    internal class Bar : BaseDecorator
    {
        private double barPrice;

        public Bar(HotelBilling hotel, double barPrice) : base(hotel)
        {
            this.barPrice = barPrice;
        }

        public override string Discription()
        {
            return hotel.Discription() + "Bar";
        }

        public override double getCost()
        {
            return hotel.getCost() + barPrice + vat();
        }

        public double vat()
        {
            return barPrice * 0.1;
        }
    }
}
