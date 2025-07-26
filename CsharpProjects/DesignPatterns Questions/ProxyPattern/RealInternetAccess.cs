using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class RealInternetAccess : InternetAccess
    {
        public override void Connect(string host)
        {
            Console.WriteLine($"Connected to the internet: {host}");
        }
    }
}
