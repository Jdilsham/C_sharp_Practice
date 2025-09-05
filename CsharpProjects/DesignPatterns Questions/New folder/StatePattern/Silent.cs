using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal class Silent : IAlertState
    {
        public void Alert()
        {
            Console.WriteLine("Silent state");
        }
    }
}
