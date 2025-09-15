using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Airport : BaseDecorator
    {
        private double airportprice;

        public Airport(HotelBilling h, double airportprice) : base(h)
        {
            this.airportprice = airportprice;
        }

        public override double getCost()
        {
            return airportprice;
        }
    }
}
