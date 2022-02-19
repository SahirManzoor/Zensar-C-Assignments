using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{

    public interface Animal
    {

        string speak();
    
    }

    public class Cat : Animal 
    {
        public string speak()
        {
            return "Meow";
        
        }

        public class Dog : Animal
        {
            public string speak()
            {
                return "BOW BOW";

            }

        }
        public class Lion : Animal
        {
            public string speak()
            {
                return "Squawck";

            }

        }
        public class shark : Animal
        {
            public string speak()
            {
                return "Ovoo";

            }

            public abstract class AnimalFactory
            {
                public abstract Animal GetAnimal(string animalType);
                public static AnimalFactory CreateAnimalFactory(string factoryType);
                {

                   if(factoryType.Equals("Sea"))
                    {
                    
                    
                    }
}
            }

        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
