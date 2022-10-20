using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Collections
//{
//    internal class MaximumNo2D
//    {
//        // Find maximum number from each row of two dimensional array with dimensions ( 3 x 4)

//        static void Main(string[] args)
//        {
//            int[,] data = new int[3, 4]
//             {
//                   {10,20,30,40 },
//                   { 50,60,70,80},
//                   { 90,100,110,120}
//             };

//            int max = data[0,1];


//            for (int i = 0; i < data.GetLength(0); i++)   // 0--> row size
//            {
//                for (int j = 0; j < data.GetLength(1); j++) // 1 --> col size
//                {
//                    if (data[i,j] > max)
//                    max = data[i,j];
//                 Console.Write($"data=[{i},{j}] = {data[i, j]}  ");
//                }
//                Console.WriteLine();
//               Console.WriteLine("Maximum value of Array: {0}", max);

//            }
//        }
//    }
//}
