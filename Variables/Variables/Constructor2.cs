using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    public class Constructor2
    {
        public int id;
        public string name;
        public float weight;
        public int age;

        public Constructor2()
        {
            Console.WriteLine("This is constructor");
            Console.WriteLine("This is id: "+id);
            Console.WriteLine("This is name: "+name);
            Console.WriteLine("This is weight: "+weight);
            Console.WriteLine("This is age: "+age);
            
        }

        public Constructor2(int id, string name, float weight, int age)
        {
            this.id = id;
            this.name = name;
            this.weight = weight;
            this.age = age;
        }
    }
    //class shri1
    //{
    //    static void Main(string[] args)
    //    {
    //        Constructor2 constructor2 = new Constructor2();
    //    }


    //}
}
