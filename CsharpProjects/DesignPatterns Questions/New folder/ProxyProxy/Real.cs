using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyProxy
{
    internal class Real : InternetAccess
    {
        public void Connect(string host)
        {
            Console.WriteLine($"Connected {host}");
        }
    }
}
