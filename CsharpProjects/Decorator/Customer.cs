using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Customer
    {
        public string Name { get; set; }

        public string Date { get; set; }

        public string Room { get; set; }

        public double Bar { get; set; }

        public double Resturant { get; set; }

        public double Wellness { get; set; }

        public double Airpayment { get; set; }

        public double NetPayment { get; set; }


        public Customer(string name, string date, string room, double bar, double resturent, double wellness, double airport, double net)
        {
            this.Name = name;
            this.Date = date;
            this.Room = room;
            this.Bar = bar;
            this.Resturant = resturent;
            this.Wellness = wellness;
            this.Airpayment = airport;
            this.NetPayment = net;
        }


    }
}
