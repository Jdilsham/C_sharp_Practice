using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorRight
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string RoomType { get; set; }
        public double BarCharge { get; set; }
        public double ResturentCharges { get; set; }
        public double WellnessCharge { get; set; }
        public double AirportCharge { get; set; }
        public double NetCharge { get; set; }

        public Customer(string name, string date, string roomtype, double bar, double resturent, double wellness, double airport, double net)
        {
            this.Name = name;
            this.Date = date;
            this.RoomType = roomtype;
            this.BarCharge = bar;
            this.ResturentCharges = resturent;
            this.WellnessCharge = wellness;
            this.AirportCharge = airport;
            this.NetCharge = net;
        }
    }
}
