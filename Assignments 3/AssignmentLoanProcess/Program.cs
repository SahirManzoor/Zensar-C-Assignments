using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentLoanProcess
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Assignement_3
    {
        class CustomEXP : ApplicationException
        {
            public CustomEXP(string msg) : base(msg)

            {

            }
        }
        class Loan
        {
            long loan_no;
            string Customer_Name;

            public Loan(int lno, string Cust_nm)
            {
                loan_no = lno;
                Customer_Name = Cust_nm;

            }

            public float EmiCalculator(float Loan_Amount, float r, float t)
            {
                Console.WriteLine("EMI Calculator");
                r = r / (12 * 100); // one month interest
                t = t * 12; // one month period
                float EMI_Amount = (Loan_Amount * r * (float)Math.Pow(1 + r, t)) / (float)(Math.Pow(1 + r, t) - 1);

                Console.WriteLine("EMI Amount of one Month is:" + EMI_Amount);
                return EMI_Amount;
            }


            public void CheckBalance(float EMI_Amount)
            {
                Console.WriteLine("Enter your Balance");
                float Account_Balance = Convert.ToSingle(Console.ReadLine());

                if (Account_Balance < EMI_Amount)
                {
                    throw new CustomEXP("Not Sufficient Balance to repay loan");
                }


            }



            public static void Main()
            {
                Loan l = new Loan(1234, "hjik");
                Console.WriteLine("Loan you have taken is 50000");
                float emi = l.EmiCalculator(50000, 13, 3);
                Console.WriteLine("EMI is: " + emi);


                try
                {
                    l.CheckBalance(emi);
                }
                catch (CustomEXP e)
                {

                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("PLEASE :::");
                    Console.WriteLine("PAY THE EMI ASAP");
                }
                Console.Read();

            }
        }


    }
}
