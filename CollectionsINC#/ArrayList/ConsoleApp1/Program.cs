using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            //contains a set of classes to contain elements in a
            //generalized manner. With the help of collections,
            //the user can perform several operations on objects like
            //the store, update, delete, retrieve, search, sort etc.

            // C# divides collection in different classes 
            // System.Collection;System.Collection.Generic namespace .
            // It provides generic implementation of standard data structures
            // Dictionary, Queues, Stacks, Linked Lists;



            //ArrayList() is a collection
            //ArrayList is an ordered collection of an object 
            //It allows dynamic memory allocation,adding,searching,sorting items in the list.
            //elements in this collection can be accessed using an integer index.
            //zero based index
            //using multidimensional is not allowed.

            ArrayList mylist = new ArrayList();
            
            mylist.Add("Sahir");
            mylist.Add("mehboob");
            mylist.Add("kalam");
            mylist.Add("suhail");
            mylist.Add("dell");
            mylist.Add("furkan");
            mylist.Add("wajid");
            mylist.Add("javeed");
            mylist.Add("serata");
            
            //1.property; to check the array list has fixed size or not
            Console.WriteLine(" Fixed size = {0}  ",mylist.IsFixedSize);

            //2.property; capacity of array list - no.of elements the array list can hold
            Console.WriteLine("capacity of arraylist = {0}",mylist.Capacity);

            //3.property;  The number of elements actually contained in the arrayList
            Console.WriteLine("count = {0}",mylist.Count);
            
            //4.property;  to check the array IsReadOnly  if it returns true we can not add,remove the list.
            Console.WriteLine("IsReadOnly =  {0}",mylist.IsReadOnly);
            
            //5.is used to get a value which indicate whether access to arrayList is
            //synchronised (thread safe)

            foreach (var item in mylist)
            {
                   Console.WriteLine(item);
            }
            
            Console.ReadLine();
        }
    
    }
}
