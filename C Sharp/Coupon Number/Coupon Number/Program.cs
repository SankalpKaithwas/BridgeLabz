using System;

namespace Coupon_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(input);
            string coupons = string.Empty;
            while (input > 0)
            {
                int number = new Random().Next(1, 123);
                coupons += (char)number;
                input--;
            }
            Console.WriteLine(coupons);

        }
    }
}
