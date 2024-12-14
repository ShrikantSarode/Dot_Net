using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class ArithmaticException
    {
        float div ; float a=1; float b=0;
        public float Div()
        {
            div = a / b;
            Console.WriteLine(div);
            return div;
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        ArithmaticException a = new ArithmaticException();
    //        a.Div();
    //    }
    //}
}
