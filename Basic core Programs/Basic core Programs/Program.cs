using System;

namespace Basic_core_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose 1 for Flipcoin");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    FlipCoin percentage = new FlipCoin();
                    Console.WriteLine("Enter numbers of time coin needs to flip");
                    int input = int.Parse(Console.ReadLine());
                    percentage.FlipCoinPercentage(input);
                    break;
                default:
                    Console.WriteLine("Input valid option");
                    break;
            }
        }



    }
}
