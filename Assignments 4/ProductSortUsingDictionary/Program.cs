using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSortUsingDictionary
{
   
             class Product
             {
            Dictionary <string, Double> ProductInfo = new Dictionary<string, double>();

            public void GetDictionary()
            {
                Console.WriteLine("Enter 10 Elements of Dictionary");
                for (int i = 0; i < 10; i++)
                {
                    ProductInfo.Add(Console.ReadLine(), double.Parse(Console.ReadLine()));
                }
            }
            public void SortDictionary()
            {
                Console.WriteLine("Sorted by Value");
                Console.WriteLine("----------------");
                foreach (KeyValuePair<string, Double> Price in ProductInfo.OrderBy(key => key.Value))
                {
                    Console.WriteLine("Key: {0}, Value: {1}", Price.Key, Price.Value);
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Product p = new Product();
                p.GetDictionary();
                p.SortDictionary();
            }
        }
    }


