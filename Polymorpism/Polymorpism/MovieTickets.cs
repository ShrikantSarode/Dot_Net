using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorpism
{
    class Tickets
    {
        public virtual void Event()
        {
            Console.WriteLine("Buy Tickets");
        }
    }
    class MovieTickets : Tickets
    {
        public override void Event()
        {
            Console.WriteLine("Buy Movie Tickets");
        }
    }
    class StandUp : Tickets
    {
        public override void Event()
        {

            Console.WriteLine("Buy standUp Tickets");
        }
    }
    class Railway : Tickets
    {
        public override void Event()
        {

            Console.WriteLine("Buy Railway Tickets");
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        Tickets tickets = new MovieTickets();
    //        tickets.Event();
    //        Tickets tickets1 = new StandUp();
    //        tickets1.Event();
    //        Tickets tickets2 = new Railway();
    //        tickets2.Event();
    //    }
    //}
}
