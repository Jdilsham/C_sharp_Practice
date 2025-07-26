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
    }
}
