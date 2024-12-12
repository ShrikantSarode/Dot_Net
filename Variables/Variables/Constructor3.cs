using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    public class Constructor3
    {
        public int RollNumber;
        public string Name;

        //here we declare or create default constructor

        public Constructor3(int RollNumber, string name)
        {
            this.RollNumber = RollNumber;
            this.Name = name;
            Console.WriteLine("This is parametetized constructor");
        }

        public void display()
        {
            Console.WriteLine("Roll Number: "+RollNumber);
            Console.WriteLine("Name: "+Name);
        }
    }
    //class shri
    //{
    //    static void Main(string[] args)
    //    {
    //        Constructor3 con3 = new Constructor3(55,"Shrikant");
    //        con3.display();
    //    }
    //}
}
