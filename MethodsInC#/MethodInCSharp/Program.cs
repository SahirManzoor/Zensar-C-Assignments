using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodInCSharp
{

    //method are a block of code that are used to perform a special task
    //gives user the ability to reuse the same code which ultimately
    //saves the excessive use of memory

    //it helps in reusabaility of that task 
    //provides beautiful structure to  aprogram

    //There might be certain situations
    //    the user want to execute a method
    //        but sometimes that method requires some valuable
    //              inputs in order to execute and complete its tasks.
    //                       These input values are known as Parameters in computer language terms.
    
    //             //4 types of methods depending upon return type and parameters(Nothing but input to method)
    internal class Program
    {
        // 1-------->parameters in c#
        //used named parameters, you can specify the value of the
        //parameter according to their names not their order in the method.
        //Or in other words, it provides us a facility to not remember parameters
        //according to their order. This concept is introduced in C# 4.0.
        //
        public stastring Animals(string s1,string s2,string s3)
        {
            string s = s1 + s2 + s3;
            return s;
        }

        static void Main(string[] args)
        {
          
            //as method is static we dont need to create an object to access it
          
            Console.WriteLine(Animals(s1: "sahir ",s3:"manzoor ",s2:"Bhat "));

            Console.ReadLine();
        }
    }
}
