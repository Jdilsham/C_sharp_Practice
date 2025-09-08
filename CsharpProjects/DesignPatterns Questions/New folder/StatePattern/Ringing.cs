using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal class Ringing : IAlert
    {
        public void Alert()
        {
            Console.WriteLine("Ringing Activated");
        }
    }
}
