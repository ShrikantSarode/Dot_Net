//using System;

//namespace Polymorphism
//{
//    class NewPassword
//    {

//        private int _oldPassword = 1234;
//        private int _newPassword;

//        public void ChangePassword(int newPassword)
//        {
//            if (newPassword != _oldPassword)
//            {
//                _newPassword = newPassword;
//                Console.WriteLine("Password Changed Successfully!");
//            }
//            else
//            {
//                Console.WriteLine("Password matches the old password. Try another one.");
//            }
//        }


//        public void ChangePassword(string newPassword)
//        {
//            if (int.TryParse(newPassword, out int password))
//            {
//                if (password != _oldPassword)
//                {
//                    _newPassword = password;
//                    Console.WriteLine("Password Changed Successfully!");
//                }
//                else
//                {
//                    Console.WriteLine("Password matches the old password. Try another one.");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Invalid input. Please enter a numeric password.");
//            }
//        }


//        static void Main(string[] args)
//        {
//            NewPassword n = new NewPassword();


//            Console.WriteLine("Welcome To the Password Changing Site");
//            Console.WriteLine("Please Select Option: ");
//            Console.WriteLine("1. Change Password  2. Exit");


//            int choice = int.Parse(Console.ReadLine());


//            if (choice == 1)
//            {
//                Console.WriteLine("Enter your new password (integer): ");
//                string newPassword = Console.ReadLine();


//                n.ChangePassword(newPassword);
//            }
//            else if (choice == 2)
//            {
//                Console.WriteLine("Exiting...");
//            }
//            else
//            {
//                Console.WriteLine("Invalid Option! Please choose a valid option.");
//            }


//        }
//    }
//}
