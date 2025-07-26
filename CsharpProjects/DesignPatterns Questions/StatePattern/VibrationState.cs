using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class VibrationState : IAlertState
    {
        public void Alert()
        {
            Console.WriteLine("THe phone is vibrating...");
        }
    }
}
