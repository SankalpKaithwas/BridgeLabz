using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_Expression
{
    public class Employee
    {
        public string Name { get; set; }
        public int ID { get; set; }
        
        public string Gender { get; set; }
        public int Salary { get; set; }

       

       

        class Program
        {
            static void Main(string[] args)
            {
                Dictionary<int, Employee> dictionaryEmployees = new Dictionary<int, Employee>()
            {
                { 101, new Employee {ID=101, Name="Pranaya", Gender="Male", Salary = 20000}},
                { 102, new Employee {ID=101, Name="Priyanka", Gender="Female", Salary = 30000}},
                { 103, new Employee {ID=101, Name="Anurag", Gender="Male", Salary = 40000}}
            };

                foreach (Employee item in dictionaryEmployees.Values)
                {
                    Console.WriteLine(item.ID + item.Name + item.Gender + item.Salary);
                }

                Func<int, int> square = number => number * number;
                Console.WriteLine(square(34));

                List<int> list = new List<int> { 1, 2, 3, 4, 5 };
                List<int> lists = list.FindAll(x => x % 2 == 0);
                List<int> listOdd = list.FindAll(x => x % 2 == 1);
                listOdd.ForEach(num => Console.WriteLine(num));
                int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
                var lessThanSix = numbers.TakeWhile(n => n < 6);

                list.ForEach(b => Console.WriteLine(b));
                lists.ForEach(list => Console.WriteLine(list));
                list.ForEach(x => Console.WriteLine(x));

                Action<string> greet = name =>
                {
                    string greeting = $"Hello {name}";
                    Console.WriteLine(greeting);
                };

                greet("Sanaklp");





            }
        }
    }
}
