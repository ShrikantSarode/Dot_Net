using System;

namespace ExceptionHandling
{
    class User
    {

        public string UserName { get; set; }
        public string Password { get; set; }

        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }


        public bool CheckCredentials(string userName, string password)
        {
            return userName == UserName && password == Password;
        }


        public string RecoverPassword(string userName)
        {
            if (userName == UserName)
            {
                return Password;
            }
            throw new Exception("Invalid Username! Cannot recover password.");
        }
    }

    class LoginSystem
    {
        private User user;

        public LoginSystem(User user)
        {
            this.user = user;
        }


        public bool CheckCredentials(string userName, string password)
        {
            return user.CheckCredentials(userName, password);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            User user = new User("Shrikant", "root");


            LoginSystem loginSystem = new LoginSystem(user);


            bool exit = false;
            while (!exit)
            {

                Console.WriteLine("Menu:");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Forget Password");
                Console.WriteLine("3. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":

                        Console.Write("Enter Username: ");
                        string loginUserName = Console.ReadLine();

                        Console.Write("Enter Password: ");
                        string loginPassword = Console.ReadLine();

                        if (loginSystem.CheckCredentials(loginUserName, loginPassword))
                        {
                            Console.WriteLine("Login successful!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid credentials!");
                        }
                        break;

                    case "2":

                        Console.Write("Enter Username to recover password: ");
                        string recoverUserName = Console.ReadLine();

                        try
                        {
                            string recoveredPassword = user.RecoverPassword(recoverUserName);
                            Console.WriteLine("Recovered Password: " + recoveredPassword);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                        break;

                    case "3":

                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }


            }
        }
    }
}
