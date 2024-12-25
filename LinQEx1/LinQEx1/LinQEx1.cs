//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace LinQEx1
//{
//    class LinQEx1
//    {
//        static void Main(string[] args)
//        {
//            // LinkedList with even numbers
//            LinkedList<int> list = new LinkedList<int>();
//            list.AddFirst(1);
//            list.AddFirst(2);
//            list.AddFirst(3);
//            list.AddFirst(4);
//            list.AddFirst(5);
//            list.AddFirst(5);
//            list.AddFirst(6);
//            list.AddFirst(7);
//            list.AddFirst(8);
//            list.AddFirst(9);
//            list.AddFirst(10);

//            // Using LINQ to filter even numbers
//            var evenNumbers = list.Where(n => n % 2 == 0);

//            // Display even numbers
//            foreach (var number in evenNumbers)
//            {
//                Console.WriteLine(number);
//            }
//            Console.WriteLine("===========================");

//            // List of products
//            List<string> products = new List<string>
//            {
//                "Iphone",
//                "Mac Book",
//                "Nokia Phone",
//                "Laptop"
//            };

//            // Displaying product names using LINQ (no changes needed here)
//            foreach (var pName in products)
//            {
//                Console.WriteLine(pName);
//            //Console.WriteLine("===========================");
//                if (pName.Length > 5)
//                {
//                    Console.WriteLine("Long: "+pName);
//                }
//                else
//                {
//                    Console.WriteLine("Short: "+pName);
//                }
//            }
//            Console.WriteLine("===========================");

//            // Using LINQ to sort product names
//            var sortedProducts = products.OrderBy(p => p).ToList();
//            foreach (var product in sortedProducts)
//            {
//                Console.WriteLine("Sorted Names: " + product);
//            }
//            Console.WriteLine("===========================");

//            // Using LINQ to filter product names longer than 5 characters
//            var longProductNames = products.Where(p => p.Length > 5);

//            // Display product names longer than 5 characters
//            foreach (var item in longProductNames)
//            {
//                Console.WriteLine(item);
//            }
//        }
//    }
//}
