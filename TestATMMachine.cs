using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class TestATMMachine
    {
        public static void Main(string[] args)
        {
            //State
            ATMMachine atmMachine = new ATMMachine();
            atmMachine.insertCard();
            atmMachine.ejectCard();
            Console.WriteLine("------------");
            atmMachine.insertCard();
            atmMachine.insertPin(1234);
            Console.WriteLine("------------");
            atmMachine.requestCash(2000);
            atmMachine.insertCard();
            Console.WriteLine("------------");
            atmMachine.insertPin(1234);

            //Proxy Pattern
            IGetATMData atmRealMachine = new ATMMachine();
            IGetATMData atmProxyMachine = new ATMProxy();

            Console.WriteLine("Current ATMProxy State: " + atmProxyMachine.getATMData());
            Console.WriteLine("Current ATMProxy Cash: " + atmProxyMachine.getCashInMachine());
            //->protected now from this//atmProxyMachine.setCashInMachine();

            //Console.WriteLine("Try to set ATMMachine? " + atmRealMachine.setCashInMachine());
            //also won't work. It's a IGetATMData object so it can't access methods outside of its contract.
        }
    }
}
