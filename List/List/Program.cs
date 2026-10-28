using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new List<int>(){ 1,2,3,4};
            number.Add(1);
            number.AddRange(new int[3] { 5, 6, 7 });
            foreach(var numbers in number)
                Console.WriteLine(numbers);
            Console.WriteLine();

            Console.WriteLine("Index of 1: " + number.IndexOf(1));
            Console.WriteLine("Last Index of 1: " + number.LastIndexOf(1));

            Console.WriteLine("Count: " + number.Count);
            
            for(var i =0;i<number.Count;i++)
            {
                if (number[i] == 1)
                    number.Remove(number[i]);
            }
            foreach(var numbers in number)
                Console.WriteLine(numbers);
            number.Clear();
            Console.WriteLine("Count: " + number.Count);


        }
    }
}
