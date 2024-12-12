using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    public class StaticConstructor
    {
        public static string DefaultSize;
        public static string DefaultCrust;

        public string size;
        public string crust;

        //Static Constructor
        static StaticConstructor()
        {
            //initialize static values

            DefaultSize = "Medium";
            DefaultCrust = "Thick Crust";

            Console.WriteLine("This Static Constructor Called");
            Console.WriteLine("===================================");
            //Console.WriteLine("DefaultSize: "+DefaultSize);
            //Console.WriteLine("DefaultCrust: "+DefaultCrust);

        }

        //Parameterized Constructure
        public StaticConstructor(string size,string crust)
        {
            this.size = size;
            this.crust = crust;
        }

        public void Display()
        {
  
            Console.WriteLine("This method is called");
            Console.WriteLine(crust);
            Console.WriteLine(size);
            
        }
    }
    //class shri
    //{
    //   static void Main()
    //    {

    //        StaticConstructor sc = new StaticConstructor("Large","Cheese");
    //        sc.Display();
    //        Console.WriteLine("===========================");

    //        StaticConstructor sc1 = new StaticConstructor(StaticConstructor.DefaultSize, StaticConstructor.DefaultCrust);
    //        sc1.Display();
    //        Console.WriteLine("===========================");

           
    //    }
    //}
       
   
}
