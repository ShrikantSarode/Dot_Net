using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    public class AadharEncap
    {
        private int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age must be Positive");
                }
            }

        }

    }
    //class AadharMain
    //{
    //    static void Main(string[] args)
    //    {
    //        AadharEncap aadhar = new AadharEncap();
    //        aadhar.Age = 23;
    //        Console.WriteLine(aadhar.Age);
    //    }

    //}
}
