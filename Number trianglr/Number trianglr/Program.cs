using System;

namespace Number_trianglr
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, l;
            Console.WriteLine("Enter Range: ");
            var ch = int.Parse(Console.ReadLine());
            for (i = 1; i <= ch; i++)
            {
                for (j = 1; j <= ch-i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write(k);
                }              
                for (l = i-1; l >= 1; l--)
                {
                    Console.Write(l);
                }
                Console.Write("\n");

            }
        }
    }
}
