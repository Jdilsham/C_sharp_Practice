using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class MobilePhone
    {
        private IAlertState alertState;

        public MobilePhone(IAlertState initialState) 
        { 
            alertState = initialState;
        }

        public void setState(IAlertState state)
        {
            alertState = state;
        }

        public void Alert()
        {
            alertState.Alert();
        }
    }
}
