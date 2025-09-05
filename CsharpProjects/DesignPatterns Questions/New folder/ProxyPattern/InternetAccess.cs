using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public abstract class InternetAccess
    {
        public abstract void Connect(string host);
    }
}
