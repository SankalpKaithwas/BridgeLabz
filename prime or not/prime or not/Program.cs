using System;

namespace prime_or_not
{

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter A Positive Inetger:");
            //var number = int.Parse(Console.ReadLine());
            //int a = 0;
            //for (int i = 1; i <= number; i++)
            //{
            //    if (number % i == 0)
            //    {
            //        a++;
            //    }
            //}
            //if (a == 2)
            //{
            //    Console.WriteLine("{0} is a Prime Number", number);
            //}
            //else Console.WriteLine("Not a Prime Number");


            Console.Write("Enter The Start Number: ");
            int startNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the End Number : ");
            int endNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The Prime Numbers between {startNumber} and {endNumber} are : ");
            for (int i = startNumber; i <= endNumber; i++)
            {
                int counter = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                    }
                }

                if (counter == 0 && i != 1)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
