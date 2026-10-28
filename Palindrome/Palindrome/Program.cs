using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Write something");
            string read = Console.ReadLine();
            bool pal = false;         
            for (int i = 0, j = read.Length - 1; i < read.Length / 2; i++, j--)
            {
                if (read[i] != read[j])
                {
                    pal = false;
                    break;
                }

                else pal = true;
            }
            if (pal)
            {
                Console.WriteLine("Palindrome");
            }
            else Console.WriteLine("Not Palindrome");


            // ANOTHER WAY================================================================================//

            //Console.WriteLine("Write something");
            //string read = Console.ReadLine();
            //string reverse = string.Empty;

            //for (var i = read.Length - 1; i >= 0; i--)	 // MAIN LOGIC
            //{
            //    reverse += read[i].ToString();
            //}
            //if (reverse == read)
            //{
            //    Console.WriteLine("Palimdrom");
            //}
            //else Console.WriteLine("Not Palindrome");

        }
    }
}
