using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    internal class BaseDecorator : Coffee
    {
        public Coffee coffee;

        public BaseDecorator(Coffee coffee)
        {
            this.coffee = coffee;
        }

        public virtual double getCost()
        {
            return coffee.getCost();
        } 

        public virtual string Discription()
        {
            return coffee.Discription();
        }
    }
}
