using System;

namespace Armstrong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int remainder,sum = 0; 
            Console.WriteLine("enter number: ");
            int number = int.Parse(Console.ReadLine());
            int temp = number;

            while (number > 0)
            {
                remainder = number % 10;
                sum += remainder * remainder * remainder;
                number /= 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Armstrong"); // 153, 370
            }
            else
            Console.WriteLine("Not armstrong");

        }
    }
}
