using System;
using System.Threading;

namespace StringsInCSharp
{
    internal class Program
    {
       static void Main(string[] args)
        {

            //   String Characteristics:  

            //t is a reference type.
            //It’s immutable(its state cannot be altered).
            //It can contain nulls.
            //It overloads the operatoIr(==).

            //working with Date time
            var date = DateTime.Now.Day;
            Console.WriteLine($"Today is {date}");
            //we have string formatting option 
            
           
            Console.WriteLine(DateTime.Today.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToString());
            Console.WriteLine("ENTER YOUR NAME");
           string userName = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                //string interpolation is for formatting or the way of concatenation
                //you do not have to worry about spaces
                
                string str =$"HI \"{userName}\" Bhai I am Leaving you in ";
                //Thread.Sleep(1200);
                Console.WriteLine(str);
            }
            //in c# null string is treated as empty string 

            //String Array collection of strings 
            string[] words = {"The","Quick","Brown","Fox","Jumps","Over","The","Lazy","Dog" };
            Console.WriteLine(words);
            
            var unreadablePhrase = string.Concat(words);
            //use of concat method to strings 

            Console.WriteLine(unreadablePhrase);
            //it is used to declare an implicit type variable,
            //that specifies the type of a variable based on initial value.
           //join method takes the string arrays and seprate each string element with separator. 
            var readablePhrase = string.Join("\\",words);
            Console.WriteLine(readablePhrase);
        }
    }
}