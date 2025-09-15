using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    internal class order
    {
        //public int id {  get; set; }
        public string name { get; set; }
        public string date { get; set; }
        public string coffeeType { get; set; }
        public string size { get; set; }
        public int quntity { get; set; }
        public string addOns { get; set; }
        public double netPayment { get; set; }

        public order(string name, string date, string coffeeType, string size, int quntity, string addOns, double netPayment)
        {
            //this.id = id;
            this.name = name;
            this.date = date;
            this.coffeeType = coffeeType;
            this.size = size;
            this.quntity = quntity;
            this.addOns = addOns;
            this.netPayment = netPayment;

        }
    }
}
