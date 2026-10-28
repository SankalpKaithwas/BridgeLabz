using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int number = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 0; i < number; i++)
            {
                factorial *= i;
            }
            int checkPower = 0;
            int power = 3;
            int result = 0;
            for (int j = 1; j <= factorial; j++)
            {
                result += (factorial / power);
            }
            //Console.WriteLine(checkPower);
            Program program = new Program();
            program.Factors(number);
            
        }

        private void Factors(int number)
        {
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("Factorial " +factorial);
        }
    }
}
