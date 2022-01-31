using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleYoutube
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("100f","Haroon");
            ht.Add("101e","Taju Bhai");
            ht.Add("102d", "Mudasir");
            ht.Add("103c", "Wajid"); 
            ht.Add("104b", "Dawood");
            ht.Add("105a", "Saheem");
            foreach (var item in ht.Keys)
            {
                Console.WriteLine(item);
            }
            foreach (var item in ht.Values)
            {
                Console.WriteLine(item);
            }
            //item is a counter like i in for

            //in order to get both key and values use DictionaryEntry(structure) collection 
            //you need to create an Obejct of DictionaryEntry to access both
            //de an object of structure data type DictionaryEntry
           
                foreach (DictionaryEntry de in ht)
                Console.WriteLine(de.Key);
                Console.WriteLine(de.Value);
            { 
            }
            Console.ReadKey();

        }
    }
}
