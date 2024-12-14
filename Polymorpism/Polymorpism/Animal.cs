using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorpism
{
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal Speaks");
        }
    }
    class Dog : Animal
    {
        public override void Speak()
        {

            Console.WriteLine("Bark");
        }
    }


    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        Animal animal = new Dog();
    //        animal.Speak();
    //    }
    //}
}
