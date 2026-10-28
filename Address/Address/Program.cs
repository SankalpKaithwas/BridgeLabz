using System;
using System.Collections.Generic;

namespace Addresses
{
    internal class Program
    {
        // take a list for name id roll number etc and use select lambada(select) and select all name and rollnumber and print that
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            int num = 34;
            string str = String.Format("{0}", num);
            Console.WriteLine(str);
            numbers.Add(6);
            List<int> number = numbers.FindAll(x => (x % 2) == 0);
            foreach (var item in number)
                Console.WriteLine($"numbers are {item}");



        }

    }
}
