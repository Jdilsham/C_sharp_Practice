using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Bar : BaseDecorator
    {
        private double bar;
        public Bar(HotelBilling h, double bar) : base(h)
        {
            this.bar = bar;
        }

        public override double getCost()
        {
            return  bar + (bar * 0.1);
        }
    }
}
