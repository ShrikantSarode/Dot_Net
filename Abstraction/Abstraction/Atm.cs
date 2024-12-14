using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Atm
    {
        public abstract void withdraw(double amount);
    }
    class BankATM : Atm
    {
        private double balance=10000;
        public override void withdraw(double amount)
        {
            if(amount > 0)
            {
                balance -= amount;
                Console.WriteLine("Withdraw Successfully!!\nThis is your latest remaining balance: " + balance);
            }
            else
            {
                Console.WriteLine("Withdraw Failed");
            }
        }

    }
    //class Program
    //{
    //   static void Main(string[] args) {
    //        Atm bank = new BankATM();
    //        bank.withdraw(100);
    //    }
    //}
}
