//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////Console.ReadLine(): Used for general text input (returns a string).
////Console.ReadKey(): Used for capturing single key presses.
////Console.Read(): Reads a single character as its Unicode value.
////For converting user input:

////int.Parse(), int.TryParse(): For integers.
////double.Parse(), double.TryParse(): For floating-point numbers.
////decimal.Parse(), decimal.TryParse(): For decimals.
////bool.Parse(), bool.TryParse(): For booleans.
////DateTime.Parse(), DateTime.TryParse(): For date and time.
////Convert.To...() methods are another way to convert strings or other types into various C# types (int, double, decimal, bool, DateTime).

//namespace Scanner
//{
//    //Define the ATM Interface
//interface IATM
//    {
//        //abstract Method
//        void DisplayBalance();

//        void Withdraw(double amount);

//        void deposit(double amount);
//    }
//    class ICICIAtm : IATM
//    {
//        private double _balance;

//        //create constructor is initialize balance
//        public ICICIAtm(double initialBalance)
//        {
//            _balance = initialBalance;
//        }

//        public void DisplayBalance()
//        {
//            Console.WriteLine("Your Current balance is: " + _balance);
//        }

//        public void Withdraw(double amount)
//        {
//            if (amount > _balance)
//            {
//                Console.WriteLine("From ICICI => insufficient balance ");
//            }
//            else
//            {
//                //balance reduce by withdrawal amount
//                _balance -= amount;
//                Console.WriteLine("From ICICI => You have Withdraw " + amount + " Remaning Balance is: " + _balance);
//            }
//        }
//        public void deposit(double amount)
//        {
//            //balance added with the deposited amount
//            _balance += amount;
//            Console.WriteLine("From ICICI => You have Deposited " + amount + " Updated balance is: " + _balance);

//        }

//    }

//    class SBIAtm : IATM
//    {
//        private double _balance;

//        public SBIAtm(double initializeBalance)
//        {
//            _balance = initializeBalance;
//        }

//        public void DisplayBalance()
//        {
//            Console.WriteLine("Your account balance is: " + _balance);
//        }
//        public void Withdraw(double amount)
//        {
//            if (amount > _balance)
//            {
//                Console.WriteLine("From SBI => Insufficient Balance!!");
//            }
//            else
//            {
//                _balance -= amount;
//                Console.WriteLine("From SBI => Withdraw Successfull" + _balance);
//            }
//        }
//        public void deposit(double amount)
//        {
//            _balance += amount;
//            Console.WriteLine("From SBI => " + amount + " Deposited SuccessFully Updated Balance is: " + _balance);
//        }



//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Create an object of each Bank
//            IATM iciciAtm = new ICICIAtm(10000);
//            IATM sbiAtm = new SBIAtm(20000);

//            Console.WriteLine("Welcome To the Atm System");
//            Console.WriteLine("Please Select Bank: ");
//            Console.WriteLine("1.ICICI 2.SBI");

//            int choice = int.Parse(Console.ReadLine());

//            IATM selectedATM = choice == 1 ? iciciAtm : sbiAtm;

//            bool exit = false;

//            while (!exit)
//            {
//                Console.WriteLine("\n Select an option :");
//                Console.WriteLine("1. Display Balance");
//                Console.WriteLine("2. Withdraw Money");
//                Console.WriteLine("3. Deposit Money");
//                Console.WriteLine("4. Exit....");

//                int option = int.Parse(Console.ReadLine());

//                switch (option)
//                {
//                    case 1:
//                        selectedATM.DisplayBalance();
//                        break;
//                    case 2:
//                        Console.WriteLine("Enter Amount for Withdraw:");
//                        double withdraw = double.Parse(Console.ReadLine());
//                        selectedATM.Withdraw(withdraw);
//                        break;
//                    case 3:
//                        Console.WriteLine("Enter Amount for Deposit:");
//                        double deposit = double.Parse(Console.ReadLine());
//                        selectedATM.deposit(deposit);
//                        break;
//                    case 4:
//                        exit = true;
//                        Console.WriteLine("Exited Bye, Thank you! Please Visit Again");
//                        break;

//                    default:
//                        Console.WriteLine("Invalid Choice");
//                        break;
//                }
//            }
//        }
//    }
//}
