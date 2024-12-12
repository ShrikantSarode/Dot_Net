using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    public class StarBucks
    {

        public static string DefaultName;
        public static string DefaultSize;
        public static float DefaultPrice;

        public string name;
        public string size;
        public float price;

        static StarBucks()
        {
            //initialize static values

            DefaultSize = "Medium";
            DefaultName = "Java";
            DefaultPrice = 100.00f;

            Console.WriteLine("This Static Constructor Called");
            Console.WriteLine("===================================");

        }
        public StarBucks(string name, string size, float price)
        {
            this.name = name;
            this.size = size;
            this.price = price;

        }

        public void Display()
        {

            Console.WriteLine("This method is called");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Size: " + size);
            Console.WriteLine("Price: " + price);

        }
    }
    //class star
    //{
    //    static void Main(string[] args)
    //    {
    //        StarBucks sb = new StarBucks("Choco Chips", "Large", 500.50f);
    //        sb.Display();
    //        Console.WriteLine("===========================");
    //        StarBucks sb1 = new StarBucks(StarBucks.DefaultName, StarBucks.DefaultSize, StarBucks.DefaultPrice);
    //        sb1.Display();
    //        Console.WriteLine("===========================");

    //    }
    //}
}
