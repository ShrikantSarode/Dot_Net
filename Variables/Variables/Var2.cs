using System;

namespace Variables
{
    public class Var2
    {
        // constant variable
        const double Pi = 3.14159;
        const int maxValue = 100;
        const string AppName = "Shrikant App";

        readonly double circleRadius;

        public Var2(double circleRadius)
        {
            this.circleRadius = circleRadius;

        }

        public override string ToString()
        {
            return $"Circle Radius: {circleRadius}";
        }

        //static void Main(string[] args)
        //{
        //    // Print constant variables
        //    Console.WriteLine("The value of Pi is: " + Pi);
        //    Console.WriteLine("The value of max value is: " + maxValue);
        //    Console.WriteLine("The value of App Name is: " + AppName);

        //    //Pi = 12; // Error: cannot assign to the constant variable

        //    Var2 v1 = new Var2(3.1);
      
        //    Console.WriteLine(v1 + " Circle Radius");
        //}
    }
}
