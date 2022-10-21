using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//namespace Collections
//{
//    public class Product
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public int Price { get; set; }

//        public Product(int id,string name,int price)
//        { 
//           this.Id = id;
//            this.Name = name;
//            this.Price = price;
//        }

//        public override string ToString()
//        {
//            return $"Id:{Id}  Name:{Name}  Price:{Price}";
//        }
//    }

//    internal class GenericDictionary
//    {
//        static void Main(string[] args)
//        {
//            Dictionary<int, string> dictionary = new Dictionary<int, string>();
//            dictionary.Add(91, "IND");

//            foreach (KeyValuePair<int, string> item in dictionary)
//            {
//                Console.WriteLine(item.Key + item.Value);
//            }

//            Console.WriteLine("For Product Class:");

//            Dictionary<int, Product> dictionary2 = new Dictionary<int, Product>();
//            dictionary2.Add(101,new Product(1,"mouse",999));
//            dictionary2.Add(102, new Product(2, "monitor",9999));
//            dictionary2.Add(103, new Product(3, "keyboard", 499));


//            foreach (KeyValuePair<int,Product> item in dictionary2)
//            {
//                Console.WriteLine($"{item.Value}");
//            }

//        }
//    }
//}
