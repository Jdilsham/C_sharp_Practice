using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    internal class Suger : BaseDecorator
    {
        public Suger(Coffee coffee) : base(coffee) { }

        public override string Discription()
        {
            return coffee.Discription() + "Suger";
        }

        public override double getCost()
        {
            return (coffee.getCost() *1.05) + (10.00 * 1.1);
        }

        
    }
}
