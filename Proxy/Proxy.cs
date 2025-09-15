using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class Proxyy : InternetAccess
    {
        private real real;
        private List<string> list;

        public Proxyy()
        {
            real = new real();
            list = new List<string>() { "Janitha.com" };
        }

        public void Connect(string host)
        {
            if (list.Contains(host))
            {
                Console.WriteLine("Restricted");
            }
            else
            {
                real.Connect(host);
            }
        }
    }
}
