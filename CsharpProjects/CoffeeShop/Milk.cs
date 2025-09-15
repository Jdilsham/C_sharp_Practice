using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    internal class Milk : BaseDecorator
    {
        public Milk(Coffee coffee) : base(coffee) { }

        public override string Discription()
        {
            return coffee.Discription() + "Milk";
        }
        public override double getCost()
        {
            return (coffee.getCost() * 1.05) + (30.00 * 1.10);
        }
    }
}
