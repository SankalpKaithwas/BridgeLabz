using System;

namespace CSharpFundamentals
{
    public class Person
    {
        public string firstName;
        public string lastName;

        public int age { get; internal set; }

        public void Introduce()
        {
            Console.WriteLine("My name is " + firstName + " " + lastName);
        }
    }
}
