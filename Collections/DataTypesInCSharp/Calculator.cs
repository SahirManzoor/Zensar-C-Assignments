using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesInCSharp
{
    internal class CalculatorClass
    {
        public void MyCalculator()
        {
            Console.WriteLine("\n");
            Console.WriteLine("_________________");
            Console.WriteLine("<---ZENSAR CALCULATOR--->");
            Console.WriteLine("_________________");
            bool g;
            do
            {
                Console.WriteLine("Enter The Number ");
                Console.WriteLine("1:Addition");
                Console.WriteLine("2:Subtraction");
                Console.WriteLine("3:Multiplication");
                Console.WriteLine("4:Division");

                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        {
                            Console.Write($" A = ");
                            int a = Convert.ToInt32(Console.ReadLine());

                            Console.Write($" B = ");
                            int b = Convert.ToInt32(Console.ReadLine());
                            int sum = a + b;
                            Console.WriteLine($"sum = {sum}");
                        }
                        break;
                    case 2:
                        {
                            Console.Write($" A = ");
                            int a = Convert.ToInt32(Console.ReadLine());

                            Console.Write($" B = ");
                            int b = Convert.ToInt32(Console.ReadLine());
                            int sub = a - b;
                            Console.WriteLine($"sub = {sub}");
                        }
                        break;
                    case 3:
                        {

                            Console.Write($" A = ");
                            int a = Convert.ToInt32(Console.ReadLine());

                            Console.Write($" B = ");
                            int b = Convert.ToInt32(Console.ReadLine());
                            int mul = a * b;
                            Console.WriteLine($"mul = {mul}");
                        }
                        break;

                    case 4:
                        {
                                Console.Write($" A = ");
                                int a = Convert.ToInt32(Console.ReadLine());

                                Console.Write($" B = ");
                                int b = Convert.ToInt32(Console.ReadLine());
                                int div = a / b;
                                Console.WriteLine($"Div = {div}");
                        }
                        break;
                    default:
                        Console.WriteLine("Not Mathcing Your Options");
                        break;
                }
                Console.WriteLine("DO YOU WANT TO Continue...\n 'y' for Yes 'n' for NO");
                int Times = Convert.ToChar(Console.ReadLine());
                if (Times == 'y')
                {
                    g = true;
                }
                else
                {
                    g = false;
                }
            } while (g);
        }
        
    }
}
