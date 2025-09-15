using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class real : InternetAccess
    {
        public void Connect(string host)
        {
            Console.WriteLine($"Connected : {host}");
        }
    }
}
