using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class ProxyInternetAccess : InternetAccess
    {
        private RealInternetAcccess realinternetaccess;
        private List<string> restrictedSites;

        public ProxyInternetAccess()
        {
            realinternetaccess = new RealInternetAcccess();
            restrictedSites = new List<string> {"janitha.com", "dilsham.com" };
        }

        public override void Connect(string host)
        {
            if (restrictedSites.Contains(host))
            {
                throw new Exception($"Access Denied =o {host}");
            }
            else
            {
                realinternetaccess.Connect(host);
            }
        }
    }
}
