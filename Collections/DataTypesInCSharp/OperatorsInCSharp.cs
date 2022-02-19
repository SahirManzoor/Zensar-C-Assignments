using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesInCSharp
{
    internal class OperatorsInCSharp
    {
        public void Casting()
        {
            int myInt = 8;
            double myDouble = myInt;

            //Type casting:: when you assign a value of one data type to another type

            //1. Automatic conversion or Implicit Type conversion

            // char -> int -> long -> float -> double
            Console.WriteLine("Implicit Type Conversion");
            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);

            //Explicit Type Casting

            //double ->float ->long ->int ->char

            // Explicit casting must be done manually by placing the type in parentheses in front of the value:
            double my_Double = 9.78;
            int my_Int = (int)my_Double;//Manual casting double into Int
            Console.WriteLine("\n");
            Console.WriteLine("Explicit Type Conversion");
            Console.WriteLine(my_Int);
            Console.WriteLine(my_Double);
            Console.WriteLine("\n");
            Console.WriteLine("______Boxing___________");
            //BOxing in Dot net
            //it is the process of converting value type to the type of  object implemented by this value type  
            int i = 123;
            object obj = i;
            Console.WriteLine($"obj after receving the value type = {obj}");
            Console.WriteLine(obj.GetType());

            //Un-BOxing in C#
            // the process of converting reference types into value types .
            Console.WriteLine("\n");
            Console.WriteLine("______Unboxing___________");

            i = (int)obj;
            Console.WriteLine($"Value type i after Unboxing = {i}");
            Console.WriteLine(i.GetType());//Gettpe is a method to get the data type of object
            Console.ReadLine();
        }
    }
}
