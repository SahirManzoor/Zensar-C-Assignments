using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
//using list 
namespace Assignment4
{

    class Shop
    {
        public static void Main()

        {
            Console.WriteLine("*******************'Welcome To SHOP FOR ALL'***********************");
            Console.WriteLine("\n");
            Shop s = new Shop();
            //using list 

            List<string> ls = new List<string>();
            Console.WriteLine("Items InStock: ");

            ls.Add("School Bags");
            ls.Add("Books");
            ls.Add("Pencil");
            ls.Add("Copy");
            foreach (var item in ls)
            {

                Console.WriteLine(item);
            }

            Console.WriteLine(" 1 or press any number to display Items Available ");
            int n = Convert.ToInt32(Console.ReadLine());


            if (n == 1)
            {
                Console.WriteLine("Enter Items to add in  Shop :");
                string newitem = Console.ReadLine();
                ls.Insert(0, newitem);
                Console.WriteLine("Item Added Successfully");
            }

            Console.WriteLine("\n");
            Console.WriteLine("********************************");
            Console.WriteLine("******** Available Stock ******");

            foreach (var item in ls)
            {

                Console.WriteLine(item);
            }
        }

    }

}
