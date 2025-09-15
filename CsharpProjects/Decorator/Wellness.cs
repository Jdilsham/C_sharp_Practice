using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Wellness : BaseDecorator
    {
        private double wellness;

        public Wellness(HotelBilling h, double wellness) : base(h)
        {
            this.wellness = wellness;
        }

        public override double getCost()
        {
            return wellness;
        }
    }
}
