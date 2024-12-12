using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    public class PrivateConstructor
    {
        public string OvenStatus;

        private PrivateConstructor()
        {
            OvenStatus = "Ready to Bake";

        }

        public void BakePizza(string pizzaName)
        {
            Console.WriteLine("Our " + pizzaName + " is ready!!");
        }
        
        //static void Main(string[] args)
        //{

        //    PrivateConstructor obj = new PrivateConstructor();
        //    Console.WriteLine(obj.OvenStatus);
        //    obj.BakePizza("Margrita Pizza");
        //}
    }
    
}
