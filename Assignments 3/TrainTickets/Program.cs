using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class TrainTickets
    {

    }
    class CustomEXP : ApplicationException
    {
        public CustomEXP(string msg) : base(msg)

        {

        }
    }
    class Passenger
    {
        public string Name;
        public int age;

        public void TicketBooking(int a)
        {

            if (a > 5)
            {
                throw new CustomEXP("Cannot Book more than 5 tickets at a time");
            }
            //else
            //{
            //    Console.WriteLine("Ticket Booked Successfully");
            //}


            int[] n = new int[a];

            for (int i = 0; i < n.Length; i++)
            {

                Console.WriteLine("Enter the Name");
                Name = Console.ReadLine();
                Console.WriteLine("Enter Age");
                age = Convert.ToInt32(Console.ReadLine());
            }

        }




    }
    class TestTrain
    {
        public static void Main()
        {
            Passenger pass = new Passenger();
            Console.WriteLine("Welcome To Train Ticket Booking PLatForm");
            Console.WriteLine("Enter No of tickets you want to Book");
            int a = Convert.ToInt32(Console.ReadLine());




            try
            {
                pass.TicketBooking(a);
                Console.WriteLine("Tickets Booked Successfully");
            }
            catch (CustomEXP e)
            {

                Console.WriteLine(e.Message);
            }

            Console.Read();
        }
    }

}