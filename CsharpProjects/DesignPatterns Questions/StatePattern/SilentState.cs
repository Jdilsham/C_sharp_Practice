using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal class SilentState : IAlertState
    {
        public void Alert()
        {
            Console.WriteLine("The phone is silent, no sound or vibration");
        }
    }
}
