using System;

namespace Sum_of_didgits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("write a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (x != 0)
            {
                sum += x % 10;
                x /=10;
            }
            Console.WriteLine("Sum is: " + sum);

            
        }
    }
}
