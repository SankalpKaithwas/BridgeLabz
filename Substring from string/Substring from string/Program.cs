using System;
using System.Text;

namespace Substring_from_string
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("	All Possible Unique Substrings From an Input String");
            Console.WriteLine("Enter Some string: ");
            string str = Console.ReadLine();
            for (int i = 0; i < str.Length; ++i)
            {
                StringBuilder subString = new StringBuilder(str.Length - i);
                for (int j = i; j < str.Length; ++j)
                {
                    subString.Append(str[j]);
                    Console.Write(subString + " ");
                }
            }
            
            Console.WriteLine("Print from start index to end index of a given string");
            Console.WriteLine(str.Substring(1,1));
        }
    }
}
