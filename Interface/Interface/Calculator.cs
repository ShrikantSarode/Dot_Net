using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Hierarchical
namespace Interface
{
    class Calculator
    {
        protected float number1;
        protected float number2;

        public Calculator(float number1, float number2)
        {
            this.number1 = number1;
            this.number2 = number2;
        }
    }
    class Add : Calculator
    {
        public Add(float number1, float number2) : base(number1, number2)
        {
            this.number1 = number1;
            this.number2 = number2;
        }

        public float Addition()
        {
            return this.number1 + this.number2;
        }
    }
    class Sub : Calculator
    {
        public Sub(float number1, float number2) : base(number1, number2)
        {
            this.number1 = number1;
            this.number2 = number2;
        }
        public float Subtraction()
        {
            return this.number1 - this.number2;
        }
    }
    //class User
    //{
    //    static void Main(string[] args)
    //    {
    //        Add add = new Add(1, 2);
    //        Console.WriteLine("Addition: "+add.Addition());

    //        Sub sub = new Sub(5, 2);
    //        Console.WriteLine("Substraction: "+sub.Subtraction());
            
    //    }
    //}
}
