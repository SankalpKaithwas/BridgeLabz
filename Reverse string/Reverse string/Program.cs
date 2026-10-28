using System;
using System.Collections.Generic;

namespace Reverse_string
{    
    class Program
    {
        static void Main(string[] args)
        {
            // for string
            Console.Write("Enter a String : ");
            string originalString = Console.ReadLine();
            string reverseString = string.Empty;
            foreach (char c in originalString)
            {
                reverseString = c + reverseString;
            }
            Console.Write($"Reverse String is : {reverseString} ");
            Console.ReadLine();


            // for number
            int reverse = 0, rem;
            Console.WriteLine("enter number: ");
            var number = int.Parse(Console.ReadLine());

            while (number > 0)
            {
                rem = number % 10;
                reverse = reverse * 10 + rem;
                number /= 10;
            }
            Console.WriteLine(reverse);
        }
    }
}
