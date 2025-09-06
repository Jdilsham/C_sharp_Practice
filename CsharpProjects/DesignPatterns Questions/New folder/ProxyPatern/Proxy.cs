using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPatern
{
    internal class Proxy : InternetAccess
    {
        private Real real;

        private List<string> list;

        public Proxy()
        {
            real = new Real();
            list = new List<string>() { "Janitha.com"};
        }

        public void Connect(string host)
        {
            if (list.Contains(host))
            {
                Console.WriteLine($"Restricted : {host}");
            }
            else
            {
                real.Connect(host);
            }
        }
    }
}
