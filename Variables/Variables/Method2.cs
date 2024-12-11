using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    public class Method2
    {
        public Method2() {
            Console.WriteLine("Constructor");
        }
        public static void Entry()
        {
            Console.WriteLine("Enter in Appointment Booking");
        }
        public void Appointment()
        {
            Console.WriteLine("Appointment Booked");

            Method2 method1 = new Method2();
            //method1.Entry();
        }
        public void CancelAppointment()
        {
            Console.WriteLine("Appointment Cancel");
        }
    }

    //class Shri
    //{
    //    static void Main(string[] args)
    //    {
    //        Method2 method = new Method2();

    //        //calling static method
    //        Method2.Entry();

    //        //non static method
    //        method.Appointment();
    //        method.CancelAppointment();




    //    }
    //}
}
