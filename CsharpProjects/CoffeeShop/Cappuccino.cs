using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    internal class Cappuccino : Coffee
    {
        public double getCost()
        {
            return 350.00;
        }

        public string Discription()
        {
            return "Cappuccino";
        }
    }
}
