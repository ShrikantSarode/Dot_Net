using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    public class BankEncap
    {
        private decimal balance;

        //create public method to add money

        public void Deposit(decimal amount)
        {
            if(amount>0)
            {
                balance += amount;
                Console.WriteLine("Deposited Successfully.. ");
            }
            else
            {
                Console.WriteLine("Deposited Failed.. ");
            }
        }
        public decimal GetBalance()
        {
            return balance;
        }
    }
    //class BankMain
    //{
    //    static void Main(string[] args)
    //    {
    //        BankEncap bank = new BankEncap();

    //        bank.Deposit(1000);

    //        Console.WriteLine("Current balance is "+bank.GetBalance());

    //    }
    //}
}
