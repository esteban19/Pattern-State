using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class HasPin : ATMState
    {
        /*Need to store instance of the Context this state interacts with*/
        private ATMMachine atmMachine;/* Context HAS A state */

        //store this state in the correct Context object(ATMMachine)
        public HasPin(ATMMachine newATMMachine)
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
            Console.WriteLine("Already entered PIN.");
        }

        public void requestCash(int cashToWithdraw)
        {
            if (cashToWithdraw > atmMachine.CashInMachine)
            {
                Console.WriteLine("Don't Have that Cash");
                Console.WriteLine("Card ejected.");
                atmMachine.setATMState(atmMachine.getNoCardState());
            }
            else
            {
                Console.WriteLine(cashToWithdraw + " is provided by the machine.");
                atmMachine.setCashInMachine(atmMachine.CashInMachine - cashToWithdraw);

                Console.WriteLine("Card ejected.");
                atmMachine.setATMState(atmMachine.getNoCardState());

                if (atmMachine.CashInMachine <= 0)
                {
                    atmMachine.setATMState(atmMachine.getNoCashState());
                }
            }
        }
    }
}
