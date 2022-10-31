using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Collections
//{
//    public class Employee
//    {
//        public string Name { get; set; }

//        public int Salary  { get; set; }

//        public Employee(string name, int salary)
//        {
//            this.Name = name;
//            this.Salary = salary;
//        }

//        public override string ToString()
//        {
//            return $"Name:{Name} Salary:{Salary}" ;
//        }
//    }
//    public class Product
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public int Price { get; set; }
//    }

//    public class GenericList
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("\nFor List Class");

//            List<int> ilist = new List<int>();

//            ilist.Add(10);
//            ilist.Add(20);
//            ilist.Add(30);
//            ilist.Insert(2, 15);
//            ilist.Remove(2);
//            ilist.RemoveAt(2);
//            ilist.Insert(0, 100);
//            ilist.Sort();
//            ilist.Reverse();

//            List<string> slist = new List<string>();

//            slist.Add("C#");
//            slist.Add("MVC");

//            foreach (int item in ilist)
//            {
//                Console.WriteLine(item);
//            }

//            //*************************************** 

//            Console.WriteLine("\nFor Employee Class ");

//            //Employee e1 = new Employee("test2", 22000);
//            //Employee e2 = new Employee("test3", 22000);

//            //List<Employee> emplist = new List<Employee>();

//            //emplist.Add(new Employee("test1", 32000));
//            //emplist.Add(new Employee("test4", 32000));

//            //// or

//            //emplist.Add(e1);
//            //emplist.Add(e2);

//            ////   or

//            List<Employee> emplist2 = new List<Employee>() // Passed value for Constructor..
//            {
//                new Employee("test1", 32000),
//                new Employee("test2", 22000),
//                new Employee("test3", 22000)
//            };

//            foreach (Employee emp in emplist2)
//            {
//                Console.WriteLine(emp);
//            }



//            // *****************************

//            Console.WriteLine("\nFor Product Class");
//            List<Product> prodlist = new List<Product>() // Assign Value by Object ..
//            {
//                new Product{Id=1,Name="mouse",Price=999},
//                 new Product{Id=2,Name="monitor",Price=9999},
//                  new Product{Id=3,Name="keyboard",Price=499},
//                   new Product{Id=4,Name="cpu",Price=2500},
//                   new Product{Id=5,Name="ssd",Price=2000},
//            };
 
//            foreach (Product item in prodlist)
//            {
//                Console.WriteLine($"{item.Id} {item.Name} {item.Price}");
//            }

            

//        }



//    }
//}
