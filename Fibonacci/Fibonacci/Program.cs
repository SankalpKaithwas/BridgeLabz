using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int fNumber=0, sNumber=1, result, number; 
            Console.WriteLine("Enter Number: ");
            number = int.Parse(Console.ReadLine());


            //++++++++++++++++++++++++++ number of elements ++++++++++++++++++++++++++++++++++++

            if (number == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.Write(fNumber + " " + sNumber + " ");

                for (int i = 2; i < number; i++)
                {
                    result = fNumber + sNumber;
                    Console.Write(result + " ");
                    fNumber = sNumber;
                    sNumber = result;
                }
            }
            Console.WriteLine();

            //++++++++++++++++++++++++++++++++++ Upto number ++++++++++++++++++++++++++++++++++++
            //if (number == 0)
            //{
            //    Console.WriteLine(0);
            //}
            //else
            //{
            //    Console.WriteLine(fNumber + " " + sNumber + " ");
            //    result = fNumber + sNumber;

            //    for (int i = 2; result < number; i++)
            //    {
            //        Console.WriteLine(result + " ");
            //        fNumber = sNumber;
            //        sNumber = result;
            //        result = fNumber + sNumber;
            //    }
            //}

        }
    }
}
