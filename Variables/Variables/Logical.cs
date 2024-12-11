using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    public class Logical
    {

        public void Login()
        {
            Boolean user = false;

            if (!user)
            {
                Console.WriteLine("Admin Login");
            }
            else
            {
                Console.WriteLine("User Login");
            }
        }

        //static void Main(string[] args)
        //{
        //    Logical logical = new Logical();
        //    logical.Login();
        //}
    }
}
