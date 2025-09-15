using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class RDining : BaseDecorator
    {
        private double rdining;

        public RDining(HotelBilling h, double rdinin) : base(h)
        {
            this.rdining = rdinin;
        }

        public override double getCost()
        {
            return rdining + (rdining * 0.1);
        }
    }
}
