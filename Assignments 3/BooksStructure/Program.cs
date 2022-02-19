using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Assignment3
{
    class InfoBooks
    {
        struct Books
        {

            public string Title;
            public string author;

        }
       static void Main()
        {
            Console.WriteLine("Insert The Information of the Books: ");
            Console.WriteLine("*************************************");
            Books[] books = new Books[10];
            int n = 1;
            int x = 1;
            for (int i = 0; i <= x; i++)
            {
                Console.WriteLine("Information Of Book: " + n);
                Console.Write("Input the Name of The Book: ");
                books[i].Title = Console.ReadLine();
                Console.Write("Input the Author: ");
                books[i].author = Console.ReadLine();
                n++;
                Console.WriteLine();


            }
            int z = 1;
            Console.WriteLine();
            for (int j = 0; j <= z; j++)
            {
                Console.WriteLine("{0}: Title = {1}   Author = {2}", j + 1, books[j].Title, books[j].author);

                Console.WriteLine();
            }



        }

    }
}