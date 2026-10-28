using System;

namespace Alphabet_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, l;
            char ch = 'A';
            for (i = 1; i <= 5; i++)
            {
                for (j = 5; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for ( k = 1; k <= i; k++)
                {
                    Console.Write(ch++);                    
                }
                ch--;
                for (l = 1 ; l < i; l++)
                {
                    Console.Write(--ch);                   
                }
                Console.Write("\n");
                
            }
        }
    }
}
