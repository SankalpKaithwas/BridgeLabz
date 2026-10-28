using System;

namespace Fibo_nth_element
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Nth number: ");

            int Number = int.Parse(Console.ReadLine());
            Number = Number - 1;        // not necessary if using <
            Console.WriteLine(Fibonacci(Number));
            
        }
        public static int Fibonacci(int number)
        {
            int fNumber = 0, sNumber = 1, result;
            if (number == 0)
            {
                return fNumber;
            }
            else
            {
                for (int i = 2; i <= number; i++)       // can do < just and delete number-1
                {
                    result = fNumber + sNumber;
                    fNumber = sNumber;
                    sNumber = result;
                }
                return sNumber;

            }                      
                
            
        }
    }
}
