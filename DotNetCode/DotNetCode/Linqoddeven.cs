//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Unit4
//{
//    class LinqExample
//    {
//        static void Main(string[] args)
//        {
//            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

//            Console.WriteLine("Using loop:");
//            foreach (int item in numbers)
//            {
//                if (item > 3)
//                {
//                    Console.WriteLine(item);
//                }
//            }

//            Console.WriteLine("\nUsing LINQ:");
//            IEnumerable<int> newlist = from item in numbers
//                                       where item > 3
//                                       select item;

//            foreach (int item in newlist)  // <-- fix: use 'newlist' instead of 'numbers'
//            {
//                Console.WriteLine(item);
//            }
//        }
//    }
//}



