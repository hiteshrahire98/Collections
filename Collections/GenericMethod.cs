using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class GenericMethod
    {
        static void Swap<T>(T a, T b)
        {
            T c;
            c = a;
            a = b;
            b = c;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        static void Main(string[] args)
        {
           // Employee e1 = new Employee("test1", 2000);
           // Employee e2 = new Employee("test1", 2000);

            Swap<int>(10, 20);
            Swap<double>(45.67, 78.66);
            Swap<string>("Hello", "hi");
           // Swap<Employee>(e1, e2);
        }


    }
}
