using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class NoCard : ATMState
    {
        /*Need to store instance of the Context this state interacts with*/
        private ATMMachine atmMachine;/* Context HAS A state */

        //store this state in the correct Context object(ATMMachine)
        public NoCard(ATMMachine newATMMachine)
        {
            atmMachine = newATMMachine;
        }

        public void insertCard()
        {
            Console.WriteLine("Please Enter a PIN");
            atmMachine.setATMState(atmMachine.getYesCardState());
        }

        public void ejectCard()
        {
            Console.WriteLine("Enter a card first.");
        }

        public void insertPin(int pinEntered)
        {
            Console.WriteLine("Enter a card first.");
        }

        public void requestCash(int cashToWithdraw)
        {
            Console.WriteLine("Enter a card first.");
        }
    }
}
