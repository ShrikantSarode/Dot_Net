using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    public class ContructorExample2
    {
        public static int id;
        public string name;
        public const float maths = 70;
        public const float english = 60;
        public const float science = 90;
        public float total;
        public float result;
        public readonly float project;


        public ContructorExample2(float project)
        {
            this.project = project;



            total = (maths + english + science + project) * 100;
            result = total / 400;

            Console.WriteLine("Maths:" + maths);
            Console.WriteLine("English:" + english);
            Console.WriteLine("Science:" + science);
            Console.WriteLine("Project:" + project);




            if (result >= 35 && result < 40)
            {

                Console.WriteLine("Result:Pass " + result);


            }
            else if (result >= 40 && result < 60)
            {

                Console.WriteLine("Result:second class " + result);

            }
            else if (result >= 60 && result < 75)
            {

                Console.WriteLine("Result:first class " + result);

            }
            else if (result >= 75 && result < 100)
            {

                Console.WriteLine("Result:Distinction class " + result);

            }
            else
            {

                Console.WriteLine("Fail "+result);

            }

        }

    }

    class shri
    {
        static void Main(string[] args)
        {

            ContructorExample2 constructor1 = new ContructorExample2(80);
        }

    }
}
