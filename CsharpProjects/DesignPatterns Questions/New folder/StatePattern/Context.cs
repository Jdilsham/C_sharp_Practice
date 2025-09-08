using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal class MobilePhone
    {
        private IAlert alert;

        public MobilePhone(IAlert initialState)
        {
            alert = initialState;
        }

        public void SetState(IAlert state)
        {
            alert = state;
        }

        public void Alert()
        {
            alert.Alert();
        }
    }
}
