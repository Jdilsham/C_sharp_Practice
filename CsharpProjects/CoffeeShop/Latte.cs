using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    internal class Latte : Coffee
    {
        public double getCost()
        {
            return 300.00;
        }

        public string Discription()
        {
            return "Latte";
        }
    }
}
