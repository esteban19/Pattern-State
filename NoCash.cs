using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class NoCash : ATMState
    {
        /*Need to store instance of the Context this state interacts with*/
        private ATMMachine atmMachine;/* Context HAS A state */

        //store this state in the correct Context object(ATMMachine)
        public NoCash(ATMMachine newATMMachine)
        {
            atmMachine = newATMMachine;
        }

        public void insertCard()
        {
            Console.WriteLine("No Cash In Machine");
        }

        public void ejectCard()
        {
            Console.WriteLine("No Cash In Machine. You didnt enter a card.");
        }

        public void insertPin(int pinEntered)
        {
            Console.WriteLine("No Cash In Machine");
        }

        public void requestCash(int cashToWithdraw)
        {
            Console.WriteLine("No Cash In Machine");
        }
    }
}
