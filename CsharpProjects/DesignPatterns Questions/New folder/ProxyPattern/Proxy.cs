using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    internal class Proxy : InternetAccess
    {
        protected Real Real;
        protected List<string> list;

        public Proxy()
        {
            Real = new Real();
            list = new List<string>() { "Janitha.com" , "Dilsham.com"};
        }

        public void Connect(string host)
        {
            if (list.Contains(host))
            {
                Console.WriteLine("Restricted");
            }
            else
            {
                Real.Connect(host);
            }
        }
    }
}
