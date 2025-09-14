using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    internal class Proxy : InternetAccess
    {
        private Real instance;

        List<string> list;

        private Proxy()
        {
            instance = new Real();

            list = new List<string>() { "janitha.com"};
        }

        public void Connect(string host)
        {
            if (list.Contains(host))
            {
                Console.WriteLine("Blocked");
            }
            else
            {
                instance.Connect(host);
            }
        }
    }
}
