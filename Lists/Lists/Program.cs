using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //var names = new List<string>();
            //while (true)
            //{
            //    Console.WriteLine("Enter Name or press enter to exit: ");
            //    string input = Console.ReadLine();
            //    if (string.IsNullOrWhiteSpace(input)) 
            //        break;
            //    names.Add(input);
            //}

            //if (names.Count > 2)
            //{
            //    Console.WriteLine("Hey there {0} ,{1} , {2}",names[0],names[1],names.Count-2);
            //}
            //else if (names.Count == 2)
            //{
            //    Console.WriteLine("Good Morning {0} and {1}",names[0],names[1]);
            //}
            //else if (names.Count == 1)
            //{
            //    Console.WriteLine("Hello {0}",names[0]);
            //}
            //else Console.WriteLine("You should put your name");

            // *****************Reverse name same as reverse string *************

            //Console.Write("What's your name? ");
            //var name = Console.ReadLine();

            //var array = new char[name.Length];
            //for (var i = name.Length; i > 0; i--)
            //    array[name.Length - i] = name[i - 1];

            //var reversed = new string(array);
            //Console.WriteLine("Reversed name: " + reversed);


            //var list = new List<int>();            

            //while (list.Count<5)
            //{
            //    Console.WriteLine("Enter  number: ");
            //    var number = int.Parse(Console.ReadLine());
            //    if (list.Contains(number))
            //    {
            //        Console.WriteLine($"Enter another Number {number} has been added already: ");
            //        continue;                    
            //    }
            //    list.Add(number);
            //}
            //list.Sort();

            //foreach (var item in list)
            //{
            //    Console.Write(item);
            //}



            var list = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter Numbers or press Quit to exit : ");
                var number = Console.ReadLine();
                if (number.ToLower() == "quit")
                    break;

                list.Add(Convert.ToInt32(number));
            }
            var unique = new List<int>();
            foreach (var item in list)
            {
                if (!unique.Contains(item))                
                unique.Add(item);
            }
            Console.WriteLine("Unique Numbers are: ");
            foreach (var items in unique)
            {
                Console.WriteLine(items);
            }                      
            
        }
    }
}
