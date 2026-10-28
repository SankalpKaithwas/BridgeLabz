using CSharpFundamentals.math;
using System;
using static System.Enum;


namespace CSharpFundamentals
{
    public class People
    {
        public int Age;             //this is a field
    }
    
    
   
    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;     //value type
            Increment(number);
            Console.WriteLine(number);

            var person = new People() { Age = 20 };     //person object And Reference Type
            MakeOld(person);
            Console.WriteLine(person.Age);

            Calculator calculator = new Calculator();
            var result = calculator.add(2, 3);
            Console.WriteLine(result);

           
        }
        public static void Increment(int number)        //this is a method
        {
            number+= 10;
        }
        public static void MakeOld(People person)
        {
            person.Age += 20;
        }
    }
}
