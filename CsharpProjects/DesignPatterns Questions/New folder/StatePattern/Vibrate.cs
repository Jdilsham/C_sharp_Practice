using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Vibrate : IAlertState
    {
        public void Alert()
        {
            Console.WriteLine("Vibrate state");
        }
    }
}
