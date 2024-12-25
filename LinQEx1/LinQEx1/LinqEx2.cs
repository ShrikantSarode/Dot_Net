//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LinQEx1
//{
//    class LinqEx2
//    {
//        static void Main(string[] args)
//        {
//            List<string> Names = new List<string>()
//            {
//                "sagar",
//                "Rani",
//                "Auresh",
//                "Ajay"
//            };

//            //List<string> filterdNames = new List<string>();

//            foreach (string name in Names)
//            {
//                if (name.StartsWith("A"))
//                {
//                    //filterdNames.Add(name);
//                }
//            }
//            //foreach (var item in filterdNames)
//            //{
//            //    Console.WriteLine(item);        

//            //}

//            //var filterName = filterdNames.Where(name => name.StartsWith("A")).ToList();
//            //Console.WriteLine(filterName);

//            List<string> filterdNames = new List<string>();

//            var filterName = filterdNames.Where(name => name.StartsWith("A"));
//            Console.WriteLine(filterName);

//            List<int> Num = new List<int> { 1, 2 };

            
//            Console.WriteLine("Original List:");
//            foreach (var num in Num)
//            {
//                Console.WriteLine(num);
//            }

           
//            int temp = Num[0];
//            Num[0] = Num[1];
//            Num[1] = temp;

            
//            Console.WriteLine("\nList After Swap:");
//            foreach (var num in Num)
//            {
//                Console.WriteLine(num);
//            }




//        }
//    }
//}
