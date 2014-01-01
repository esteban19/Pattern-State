using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    /* State interface */
    public interface ATMState
    {
        void insertCard();
        void ejectCard();
        void insertPin(int pinEntered);
        void requestCash(int cashToWithdraw);
    }
}
