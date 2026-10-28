using System;

namespace Reverse_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a Sentence/Something");
            string read = Console.ReadLine();            
            string[] words = read.Split(' ');
            Array.Reverse(words);
            foreach (var s in words)
            {
                Console.Write(s + " ");               
            }
            Console.WriteLine();
        }
    }
}
