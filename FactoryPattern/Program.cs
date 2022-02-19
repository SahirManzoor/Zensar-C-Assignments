using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{

        public interface CreditCard
        { 
            string GetCardType();
            int GetCreditLimit();
            int GetAnnualCharge();
        }

    class Titanium : CreditCard
    {
        public string GetCardType()
        {
            return "Titanium Edge";
        }
        public int GetCreditLimit()
        {
            return 25000;
        }
        public int GetAnnualCharge()
        {
            return 1500;
        }
    }
    class MoneyBack : CreditCard
    {
        public string GetCardType()
        {
            return "MoneyBack";
        }
        public int GetCreditLimit()
        {
            return 15000;
        }
        public int GetAnnualCharge()
        {
            return 500;
        }
    }
    public class Platinum : CreditCard
    {
        public string GetCardType()
        {
            return "Platinum Plus";
        }
        public int GetCreditLimit()
        {
            return 35000;
        }
        public int GetAnnualCharge()
        {
            return 2000;
        }
    }

    //  A factory is an object which is used for creating other objects
    //in this program if we want to add one more class ,we need to change the whole code in client so to
    //avoid the problem of this 
    //we will implement a class of factory which will help us in avoiding 
    //direct creation of object .

    class Client
    {
        public static void Main(string[] args)
        {
            /* CreditCard carddetails = null;
             Console.WriteLine("enter Card Type:");
             string cardType = Console.ReadLine();
             if (cardType == "MoneyBack")
             {
                 carddetails = new MoneyBack();
             }
             else if (cardType == "Titanium")
             {
                 carddetails = new Titanium();
             }
             else if (cardType == "Platinum")
             {
                 carddetails = new Platinum();
             }
             else
             {
                 Console.WriteLine("Invalid Card Type");
             }
             if (carddetails != null)
             {
                 Console.WriteLine("CardType : " + " " + carddetails.GetCardType());
                 Console.WriteLine("CreditLimit : " + " " + carddetails.GetCreditLimit());
                 Console.WriteLine("Annual Charges : " + " " + carddetails.GetAnnualCharge());
             }
             Console.Read();
         */
            Console.WriteLine("Enter card Details");
            string cardType = Console.ReadLine();

            //Invoking the CreditCardFactory Method to create the object not the actual concreate class





        }



    }
}
    

