using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesInCSharp
{
    internal class ControlStatemenets
    {
        //struct Student
        //{
        //    int st;
        //    string name;
        //};
        public void  Controlstatement()
        {
           //int[] arr; definiing of array ,arrays are allocated dynamically in c#
            
            //data type <name of array> = new data_type [Size]

            int[] arr = new int[5]{1,2,3,4,5}; //initialization of an array of type int, comprises of 5 elements

            
            //Student[] str = new Student[3]; //Initialization of object type array
            Console.WriteLine("Array of Numers");
            Console.WriteLine("_______________");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
            Console.WriteLine("You want to see the magic of Continue");
            Console.WriteLine("Enter an element to skip in a loop from 1--5");
            
            int skip = Convert.ToInt32(Console.ReadLine());
            //Continue 
            foreach (var item in arr)
            {
                if (item == skip)
                    continue;                              //is used to skip over the execution part of a  loop on a certain condition.
                Console.WriteLine(item);
            }
            // Clone method can be used to create shallow copy of a array.
            Console.WriteLine("Cloned Array:::");
            int[] clonedarray = (int[]) arr.Clone();

            Console.WriteLine(clonedarray);

        }
    }
}
