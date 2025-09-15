using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    internal class Espresso : Coffee
    {
        public double getCost()
        {
            return 200.00;
        }

        public string Discription()
        {
            return "Espresso";
        }
    }
}
