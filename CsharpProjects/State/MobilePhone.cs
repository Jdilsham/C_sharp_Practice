using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class MobilePhone
    {
        private IAlert state;

        public MobilePhone(IAlert initialState)
        {
            state = initialState;
        }

        public void setState(IAlert setState)
        {
            state = setState;
        }

        public void PhoneAlert()
        {
            state.Alert();
        }
    }
}
