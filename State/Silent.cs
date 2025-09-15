using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Silent : IAlert
    {
        public void Alert()
        {
            Console.WriteLine("Silent...");
        } 
    }
}
