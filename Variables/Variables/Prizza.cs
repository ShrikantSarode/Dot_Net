using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    public class Prizza
    {
        public string PizzaName;
        public string PizzaSize;
        public float PizzaPrice;
        public int Qauntity;
        public string Customize;



        public Prizza(string PizzaName, string PizzaSize, float pizzaPrice, int qauntity, string customize)
        {
            this.PizzaName = PizzaName;
            this.PizzaSize = PizzaSize;
            this.PizzaPrice = pizzaPrice;
            this.Qauntity = qauntity;
            this.Customize = customize;
        }

        //copy constructor
        public Prizza(Prizza p)
        {
            this.PizzaName = p.PizzaName;
            this.PizzaSize = p.PizzaSize;
            this.PizzaPrice = p.PizzaPrice;
            this.Qauntity = ++p.Qauntity;
            this.Customize = p.Customize;

        }

        public void display()
        {
            Console.WriteLine("Pizza Name: " + PizzaName);
            Console.WriteLine("Pizza Size: " + PizzaSize);
            Console.WriteLine("Pizza Price: " + PizzaPrice);
            Console.WriteLine("Pizza Quantity: " + Qauntity);
            Console.WriteLine("Pizza Customize: " + Customize);
        }

    }
    //class PrizzaMain
    //{
    //    static void Main(string[] args)
    //    {
    //        Prizza prizza = new Prizza("Margrita", "M", 500.50f, 1, "Coca Cola");
    //        prizza.display();
    //        Console.WriteLine("============================");

    //        Prizza prizza1 = new Prizza(prizza);
    //        prizza1.display();
    //        Console.WriteLine("============================");

    //        Prizza prizza2 = new Prizza(prizza);
    //        prizza2.display();


    //    }
    //}
}
