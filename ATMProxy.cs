using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    //going to create and destroy ATMMachine objects
    /// <summary>
    /// provide access to only those methods we consider
    /// to be safe.
    /// </summary>
    public class ATMProxy : IGetATMData
    {
        private ATMMachine atmMachine;

        public ATMState getATMData()
        {
            atmMachine = (atmMachine != null) ? atmMachine : new ATMMachine();
            return atmMachine.getATMData();//calls ATMMachine's getATMData()!
        }

        public int getCashInMachine()
        {
            atmMachine = (atmMachine != null) ? atmMachine : new ATMMachine();
            return atmMachine.getCashInMachine();//calls ATMMachine's getATMData()!
        }
    }
}
