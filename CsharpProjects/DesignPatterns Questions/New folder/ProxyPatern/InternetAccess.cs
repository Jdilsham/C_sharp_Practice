using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPatern
{
    public interface InternetAccess
    {
        void Connect(string host);
    }
}
