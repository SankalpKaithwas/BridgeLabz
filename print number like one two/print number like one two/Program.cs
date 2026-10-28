using System;

namespace print_number_like_one_two
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, rem;
            Console.WriteLine("Enter Number: ");
            var n = int.Parse(Console.ReadLine());
            while (n>0)
            {
                rem = n % 10;
                sum = sum * 10 + rem;
                n /= 10;
            }
            n = sum;
            while (n>0)
            {
                rem = n % 10;
                switch (rem)
                {
                    case 1: Console.WriteLine("One");
                        break;
                    case 2: Console.WriteLine("Two");
                        break;
                    case 3:
                        Console.WriteLine("Three");
                        break;
                    case 4:
                        Console.WriteLine("Four");
                        break;
                    case 5:
                        Console.WriteLine("Five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("Seven");
                        break;
                    case 8:
                        Console.WriteLine("Eight");
                        break;
                    case 9:
                        Console.WriteLine("Nine");
                        break;
                    case 0:
                        Console.WriteLine("Zero");
                        break;
                    default:
                        Console.WriteLine("HAHA");
                        break;
                }
                n /= 10;
            }
        }
    }
}
