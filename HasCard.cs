using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class HasCard : ATMState
    {
        /*Need to store instance of the Context this state interacts with*/
        private ATMMachine atmMachine;/* Context HAS A state */

        //store this state in the correct Context object(ATMMachine)
        public HasCard(ATMMachine newATMMachine)
        {
            atmMachine = newATMMachine;
        }

        public void insertCard()
        {
            Console.WriteLine("You can't enter more than one card");
        }

        public void ejectCard()
        {
            Console.WriteLine("Card ejected.");
            atmMachine.setATMState(atmMachine.getNoCardState());
        }

        public void insertPin(int pinEntered)
        {
            if (pinEntered == 1234)
            {
                Console.WriteLine("Correct PIN");
                atmMachine.CorrectPinEntered = true;
                atmMachine.setATMState(atmMachine.getHasPin());
            }
            else
            {
                Console.WriteLine("Wrong PIN");
                atmMachine.CorrectPinEntered = false;
                Console.WriteLine("Card ejected.");
                atmMachine.setATMState(atmMachine.getNoCardState());
            }
        }

        public void requestCash(int cashToWithdraw)
        {
            Console.WriteLine("Enter PIN First");
        }
    }
}
