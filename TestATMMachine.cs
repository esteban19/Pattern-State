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
        }
    }
}
