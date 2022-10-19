using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//namespace Collections
//{
//    // Count number of occurrences of a number in an array [1,2,3,1,3,4,5]

//    public class NoOfOccurrences
//    {
        
//        static void Main(string[] args)
//        {
//            int[] arr = new int[7];
//            int[] counter = new int[7];

//            Console.WriteLine("Enter elements");
//            for (int i = 0; i < arr.Length; i++)
//            {
//                arr[i] = Convert.ToInt32(Console.ReadLine());
//                counter[i] = -1;
//            }

//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (counter[i] == 0)
//                    continue;

//                counter[i] = 1;

//                for (int j = i + 1; j < arr.Length; j++)
//                {
//                    if (arr[i] == arr[j])
//                    {
//                        counter[i]++;
//                        counter[j] = 0;
//                    }
//                }
//            }
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (counter[i] == 0)
//                    continue;

//                Console.WriteLine($"{arr[i]} count is {counter[i]}");
//            }
//        }




//        //static void Main(string[] args)  // For Single 1 digit.
//        //{
//        //    int[] arr = new int[] { 1, 2, 3, 1, 3, 4, 5 };
//        //    int one = 1;

//        //    int count = 0;

//        //    for (int i = 0;i<arr.Length;i++)
//        //    {
//        //        if (arr[i] == one)
//        //        {
//        //            count++;
//        //        }

//        //    }                       

//        //    Console.WriteLine($"The number {one} appears {count} in array");

//        //}
//    }
//}
