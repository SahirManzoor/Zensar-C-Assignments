using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesInCSharp
    //Data Types are defined the type of data a variable can hold.
    //defined in System namespace.
    //in c# is strongly types programming language 
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //creating object of class OperatorsInCSharp
            OperatorsInCSharp cast = new OperatorsInCSharp();
            cast.Casting();

            //instantaiting another class of OperatorClass while creating obj op.
            Console.WriteLine("\n");
            Console.WriteLine("Voting class using ternary Operator");
            OperatorClass op = new OperatorClass();
            op.CastVote();// using method of class 
            

            //Calculator class
            CalculatorClass cl = new CalculatorClass();
            cl.MyCalculator();
            //Control Statemnts ,foreach loop in c#, arrays, jump statements
            Console.WriteLine("Arrays,Control Statements,Jump Statements in c#");
            ControlStatemenets Cs = new ControlStatemenets();
            Cs.Controlstatement();
            Console.ReadLine();


        }
    }
}
