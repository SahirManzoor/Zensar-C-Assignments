using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQueries
{
    class Employee
    {
        /*LINQ offers an object-based, 
       * language-integrated way to query over data no matter where that data came from.
       * So through  LINQ we can query database, XML as well as collections. 
       * Compile time syntax checking
       * It allows you to query collections like arrays,
       * enumerable classes etc in the native language of your application,
       * like VB or C# in much the same way as you would query a database using SQL*/
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string DOB { get; set; }
        public string DOJ { get; set; }
        public string City { get; set; }

        static void Main()
        {
            List<Employee> empList = new List<Employee>()
            {
                new Employee() { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = "16/11/1984", DOJ = "8/6/2011", City = "Mumbai" },
                new Employee() { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = "20/08/1984", DOJ = "7/7/2012", City = "Mumbai" },
                new Employee() { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = "14/11/1987 ", DOJ = "12/4/2015 ", City = "Pune" },
                new Employee() { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = "3/6/1990", DOJ = "2/2/2016 ", City = "Pune" },
                new Employee() { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = "8/3/1991", DOJ = "2/2/2016 ", City = "Mumbai" },
                new Employee() { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = "2/12/1989", DOJ = "1/6/2015 ", City = "Mumbai" },
                new Employee() { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate ", DOB = "11/11/1993", DOJ = "6/11/2014 ", City = "Chennai" },
                new Employee() { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = "12/8/1992  ", DOJ = "3/12/2014 ", City = "Chennai" },
                new Employee() { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = "12/4/1991", DOJ = "2/1/2016", City = "Pune" }

            };

            /* Display detail of all the employee*/
            /*Linq Queries*/
            /*  There are two basic ways to write a LINQ query to IEnumerable collection or IQueryable data sources.
                  Query Syntax or Query Expression Syntax
                  Method Syntax or Method Extension Syntax or Fluent*/
            

            //foreach (var s in empList)
            //{
              //  Console.WriteLine(s.EmployeeID + "\t" + s.FirstName + "\t" + s.LastName + "\t" + s.Title + "\t" + s.DOB + "\t" + s.DOJ + "\t" + s.City);
            //}
               

            //b.Display details of all the employee whose location is not Mumbai

            var LocationNotMumbai = empList.Where(s => s.City !="Mumbai");
            foreach (var s in LocationNotMumbai)
            {
              Console.WriteLine(s.EmployeeID + "\t" + s.FirstName + "\t" + s.LastName + "\t" + s.Title + "\t" + s.DOB + "\t" + s.DOJ + "\t" + s.City);
            }


            var TitleManager = empList.Where(s => s.Title == "AsstManager");
            foreach (var s in TitleManager)
            {
                Console.WriteLine(s.EmployeeID + "\t" + s.FirstName + "\t" + s.LastName + "\t" + s.Title + "\t" + s.DOB + "\t" + s.DOJ + "\t" + s.City);
            }

            Console.WriteLine();

            var lastnameinlist = empList.Where(s => s.LastName == "S%");
            foreach (var s in lastnameinlist)
            {
                Console.WriteLine(s.EmployeeID + "\t" + s.FirstName + "\t" + s.LastName + "\t" + s.Title + "\t" + s.DOB + "\t" + s.DOJ + "\t" + s.City);
            }

            

            Console.WriteLine();
            var e = empList.Where(s => s.Title == "Consultant" && s.Title == "Associate");
            foreach (var s in e)
            {
                Console.WriteLine(s.EmployeeID + "\t" + s.FirstName + "\t" + s.LastName + "\t" + s.Title + "\t" + s.DOB + "\t" + s.DOJ + "\t" + s.City);
            }

            Console.ReadLine();
        }
    }
}