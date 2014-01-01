using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    /* Context */
    public class ATMMachine
    {
        ATMState hasCard;
        ATMState noCard;
        ATMState hasCorrectPin;
        ATMState atmOutOfMoney;

        ATMState atmState;

        public int CashInMachine
        {
            get;
            set;
        }
        public bool CorrectPinEntered
        {
            get;
            set;
        }
        //public int cashInMachine = 2000;
        //public bool correctPinEntered = false;

        

        public ATMMachine()
        {
            CashInMachine = 2000;
            CorrectPinEntered = false;

            hasCard = new HasCard(this);
            noCard = new NoCard(this);
            hasCorrectPin = new HasPin(this);
            atmOutOfMoney = new NoCash(this);

            //initialize
            atmState = noCard;
            if (CashInMachine < 0)
            { atmState = atmOutOfMoney;  }

        }
        /*Setting the context.*/
        public void setATMState(ATMState newATMState)
        {
            atmState = newATMState;
        }
        public void setCashInMachine(int newCashInMachine)
        {
            CashInMachine = newCashInMachine;
        }

        public void insertCard()
        {
            atmState.insertCard();
        }
        public void ejectCard()
        {
            atmState.ejectCard();
        }
        public void requestCash(int cashToWithdraw)
        {
            atmState.requestCash(cashToWithdraw);
        }
        public void insertPin(int pinEntered)
        {
            atmState.insertPin(pinEntered);
        }

        public ATMState getYesCardState() { return hasCard; }
        public ATMState getNoCardState() { return noCard; }
        public ATMState getHasPin() { return hasCorrectPin; }
        public ATMState getNoCashState() { return atmOutOfMoney; }


    }
}
