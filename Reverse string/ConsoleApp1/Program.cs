using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "write Something";
            string reverse = "";
            List<string> wordsList = new List<string>();
            string[] words = str.Split(new[] { " " }, StringSplitOptions.None);
            for (int i = words.Length - 1; i >= 0; i--)
            {
                reverse += words[i] + " ";
            }
            wordsList.Add(reverse);
            foreach (string s in wordsList)
            {
                Console.WriteLine(s);
            }
        }
    }
}
