using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class ProxyInternetAccess : InternertAccess
    {
        private RealInternetAccess realInternetAccess;
        private List<string> restrictedSites;

        public ProxyInternetAccess()
        {
            realInternetAccess = new RealInternetAccess();
            restrictedSites = new List<string> { "jani.com", "dil.com" };
        }


    }
}
