using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class MobilePhone
    {
        private IAlert alert;

        public MobilePhone(IAlert alert)
        {
            this.alert = alert;
        }

        public void setState(IAlert alert)
        {
            this.alert = alert;
        }

        public void Alert()
        {
            this.alert.Alert();
        }

    }
}
