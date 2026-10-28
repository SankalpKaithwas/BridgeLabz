using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int fact = 1;
            Console.WriteLine("Enter number: ");
            var number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                fact *= i;
            }
            Console.WriteLine(fact);
        }
    }
}
