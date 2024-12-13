using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface ICICIBank
    {
        static string Name = "Ram";
        static string AccountType = "Saving Account";

       

    }
    interface Sbi
    {
        void Withdraw(float amount);
        void showBalance();

    }

    class Atm : ICICIBank, Sbi
    {
        
        public void showBalance()
        {
            float balance = 9000000f;

        }

        public void Withdraw(float amount)
        {
            float balance = 9000000f;
            if (amount > 0)
            {
                Console.WriteLine(amount + "rs Transaction Successfull");
                balance -= amount;

                Console.WriteLine("Current Balance is: " + balance);

            }
            else
            {
                Console.WriteLine("Transaction Failed");
            }
        }

        //static void Main(string[] args)
        //{
        //    Atm atm = new Atm();
        //    Console.WriteLine(ICICIBank.Name);
        //    Console.WriteLine(ICICIBank.AccountType);
        //    atm.Withdraw(100);
        //    atm.showBalance();

        //}

    }
}
