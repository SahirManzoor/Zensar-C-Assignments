using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPLScore
{
    class Cricket
    {
        public void PointsCalculation(int[] no_of_matches)
        {
            Console.WriteLine("______________________________");
            Console.WriteLine("Enter the Points to each match");
            Console.WriteLine("______________________________");
            int j = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < no_of_matches.Length; i++)
            {
                no_of_matches[i] *= j;
            }

        }
        public void DisplayPoints(int[] no_of_matches)
        {
            Console.WriteLine("\n");
            Console.WriteLine("____________");
            Console.WriteLine("LEADER BOARD");
            Console.WriteLine("____________");
            for (int i = 1; i < no_of_matches.Length; i++)
            {
                Console.WriteLine("Team{0} = {1} points", i,no_of_matches[i]);
            }
        }
        public int Total(int[] no_of_matches)
        {
            int sum = 0;
            for (int i = 1; i < no_of_matches.Length; i++)
            {
                sum = sum + no_of_matches[i];
            }
            return sum;
        }
        public double Avg(int[] no_of_matches)
        {
            double avg;
            avg = Total(no_of_matches) / 6.0;
            return avg;
        }
    }
     
    //main class
    class Program 
    {
        static void Main(string[] args)
        {
            int[] m = new int[6];
            Console.WriteLine("__________Score Board Application________");
            Console.WriteLine("_________________________________________");

            for (int i = 1; i < m.Length; i++)
            {
                Console.WriteLine("Enter the Matches played by Team {0}:", i);
                m[i] = Convert.ToInt32(Console.ReadLine());
            }

            Cricket C = new Cricket();
            C.PointsCalculation(m);
            C.DisplayPoints(m);
            int s = C.Total(m);
            double a = C.Avg(m);

            Console.WriteLine("\n");
            
            Console.WriteLine("Total Points  ={0} \nAverage points scored by teams = {1} ", s, a);
        }
    
    }
}
