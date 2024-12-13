using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{

    interface Payment
    {
        public abstract void PaymentGateway();
    }
    interface Track
    {
        public abstract void Tracking();
    }

    class Ola : Payment, Track
    {
        public void BookRide()
        {
            Console.WriteLine("Ride Booking");
        }

        public void CancelRide()
        {
            Console.WriteLine("Ride Cancallation");
        }

        public void SearchRide()
        {
            Console.WriteLine("Ride Searching");
        }

        public void Tracking()
        {
            Console.WriteLine("Ride Tracking");
        }
        public void PaymentGateway()
        {
            Console.WriteLine("Ride PaymentGateway");
        }

        //static void Main(string[] args)
        //{
        //    Ola ola = new Ola();
        //    ola.SearchRide();
        //    ola.BookRide();
        //    ola.Tracking();
        //    ola.CancelRide();
        //    ola.PaymentGateway();
        //}


    }
}
