using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Prizza
    {
        public abstract void AddPizza();
    }
    class Customer : Prizza
    {
        private int quantity = 1;
        public override void AddPizza()
        {



            Console.WriteLine("Pizza Added!! \n Quantity: " + quantity++);




        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Prizza p1 = new Customer();
            //p1.AddPizza();
            //Prizza p2 = new Customer();
            //p2.AddPizza();


            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Press 1.To Add 2.Exit");
                int choice = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Add");
                        p1.AddPizza();
                        break;
                    case 2:
                        exit = true;
                        Console.WriteLine("Exited!!");
                        break;
                }
            }

        }
    }
}
