using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3Property
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Assignment_3
    {

        struct Books
        {
            public string title;
            public string author;

            private int book_id { get; set; }

            public void display()
            {
                title = "Lord Of The Rings";
                Console.WriteLine("Title of the book: " + title);
                author = "J.R.R. Tolkien";
                Console.WriteLine("Author of the Book: " + author);
                book_id = 452;
                Console.WriteLine("Book Id: " + book_id);
            }
            class Book
            {
                public static void Main()
                {
                    Books b1 = new Books();
                    b1.display();

                    Console.Read();
                }

            }

        }
    }
}
