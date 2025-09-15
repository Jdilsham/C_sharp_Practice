using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPractice
{
    internal interface StandardRoom : HottelBilling
    {
        public double getCost()
        {
            return 15000.00;
        }

        public string Discription()
        {
            return "Standard";
        }
    }
}
