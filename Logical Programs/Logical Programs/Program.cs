using System;

namespace Logical_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number");
            //int number = int.Parse(Console.ReadLine());
            //PerfectNumber(number);
            //   Console.WriteLine("Enter a number");
            //   int number = int.Parse(Console.ReadLine());///12314

            //  Console.WriteLine(ReverseNumber(number));
            // FibonacciSeries(number);
            // Palindrome(number);
            string name = Console.ReadLine();
            Console.WriteLine(ReverseString(name));
            


        }

       

        private static string ReverseString(string name)
        {
            string reverse = string.Empty;

            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverse += name[i];
            }
            return reverse;
        }

        private static void Palindrome(int number)
        {
            int reverse = 0;
            int temp = number;
            int rem = 0;

            for (int i = number; number > 0; i--)
            {
                rem = number % 10;
                reverse = (reverse * 10) + rem;
                number /= 10;
            }
            if (temp == reverse)
            {
                Console.WriteLine("palindrome");
            }
            else
            {
                Console.WriteLine("Not palindrome");
            }
        }

        private static void FibonacciSeries(int number)
        {
            int firstNumber = 0;
            int secondNumber = 1;
            int result = 0;
            if (number <= 1)
            {
                Console.WriteLine(firstNumber + "  " + secondNumber + " ");
            }
            else
            {
                Console.Write(firstNumber + " " + secondNumber + " ");
                for (int i = 2; i <= number; i++)
                {
                    result = firstNumber + secondNumber;
                    Console.Write(result + " ");
                    firstNumber = secondNumber;
                    secondNumber = result;
                }
            }

        }

        private static int ReverseNumber(int number)
        {
            //string reverse = "";
            int reverse = 0;
            int rem = 0;
            for (int i = number; number > 0; i--)
            {
                rem = number % 10; //4,
                reverse = (reverse * 10) + rem;//411
                number /= 10;

            }
            return reverse;
        }

        private static void PerfectNumber(int number)
        {
            int temp = number;
            int div = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    div += i;
                }

            }
            if (temp == div)
            {
                Console.WriteLine($"{temp} is a perfect number");
            }
            else
            {
                Console.WriteLine($"{temp} is not a perfect number");
            }
        }
    }
}
