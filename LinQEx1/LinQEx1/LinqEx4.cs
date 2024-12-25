using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQEx1
{
     class LinqEx4
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1,2,3,4,5,6};
            
            IEnumerable<int> evenNumber = numbers.Where(n=> n%2 ==0);

            Console.WriteLine("Even Numbers: ");

            foreach (var num in evenNumber)
            {
                Console.WriteLine(num);
            }
        }
    }
}
