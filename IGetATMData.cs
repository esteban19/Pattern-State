using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public interface IGetATMData //getting business requirement to implement query for state of ATM
    {
        ATMState getATMData();
        int getCashInMachine();
    }
}
