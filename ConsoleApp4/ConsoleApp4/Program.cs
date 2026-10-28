using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person.Display();

            Console.WriteLine((char)122);
        }
    }
    static class Person
    {
       public static void Display()
        {
            Console.WriteLine("Display");
        }
    }
}
