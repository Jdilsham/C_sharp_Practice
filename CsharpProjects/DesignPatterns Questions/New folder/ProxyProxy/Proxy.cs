using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyProxy
{
    internal class Proxy : InternetAccess
    {
        protected Real real;
        protected List <string> list;
            
        public Proxy()
        {
            real = new Real();
            list = new List<string>() { "Janitha" , "Dilsham"};
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
