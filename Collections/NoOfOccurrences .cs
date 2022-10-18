using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Collections
{
    // Count number of occurrences of a number in an array [1,2,3,1,3,4,5]

    public class NoOfOccurrences
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 1, 3, 4, 5 };
            int one = 1;
            int two = 2;
            int three = 3;
            int four = 4;
            int five = 5;
            int count = 0;

            for (int i = 0;i<arr.Length;i++)
            {
                if (arr[i] == one)
                {
                    count++;
                }
                else if (arr[i] == two)
                {
                    count++;
                }
                else if (arr[i] == three)
                {
                    count++;
                }
               else if (arr[i] == four)
                {
                    count++;
                }
                if (arr[i] == five)
                {
                    count++;
                }
            }
            Console.WriteLine($"The number {one} appears {count} in array");
            Console.WriteLine($"The number {two} appears {count} in array");
            Console.WriteLine($"The number {three} appears {count} in array");
            Console.WriteLine($"The number {four} appears {count} in array");
            Console.WriteLine($"The number {five} appears {count} in array");


        }
    }
}
