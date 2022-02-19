using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesInCSharp
{
    internal class OperatorClass
    {
        //. Operators allow us to perform different kinds of operations on operands.
        //ternary operator/conditional operator takes 3 operands..
        //condition ? first_exp : Second _exp;
        public void CastVote()
        {
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            //using of ternary operator to evalauate the 3 operands .

            //variable = (condition)  ? Expression_true :Expression False ;
              string Can_He_Vote = age > 20 ? "He can Vote And Drive ": "He can not vote";
            Console.WriteLine(Can_He_Vote);
        }
    }
}
