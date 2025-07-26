using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class ProxyInternetAccess : InternetAccess
    {
        private RealInternetAccess realInternetAccess;
        private List<string> restrictedSites;

        public ProxyInternetAccess()
        {
            realInternetAccess = new RealInternetAccess();
            restrictedSites = new List<string> {"janitha.com","dilsham.com" };
        }

        public override void Connect(string host)
        {
            if (restrictedSites.Contains(host))
            {
                throw new Exception($"Access Denied to {host}. This site is restricted.");
            }
            else
            {
                realInternetAccess.Connect(host);
            }
        }
    }
}
