using System;
using System.Collections.Generic;

namespace WorkShop
{
    public class Company
    {
        private readonly string companyName;
        private readonly int empWageprHr;
        private readonly int fulltime;
        private readonly int part;
        private readonly int maxwrkhr;
        private readonly int maxdays;

        //Constructor
        public Company(String CompanyName, int EmpWageprHr, int Fulltime, int part, int maxwrkhr, int maxdays)
        {
            companyName = CompanyName;
            empWageprHr = EmpWageprHr;
            fulltime = Fulltime;
            this.part = part;
            this.maxwrkhr = maxwrkhr;
            this.maxdays = maxdays;
        }

        void AddCompany()
        {
            //Company company = new Company(CompanyName)
        }
    }
    class EmpWageCalculation
    {
        private Dictionary<string, int> dictionary = new Dictionary<string, int>();
    }

    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            int rem;

            int originalNumber = number;
            double result = 0;
            for (int i = 1; number > 0; i++)//153
            {
                rem = number % 10;//3
                result += Math.Pow(rem, 3);//27,125,1
                number /= 10;//15
            }

            if (result == originalNumber)
            {
                Console.WriteLine("armstrong");
            }
            else
            {
                Console.WriteLine("Not armstrong");
            }
        }

    }

}


