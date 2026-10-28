using System;
using System.Collections.Generic;

namespace RegexPractice
{

    internal class Program
    {

        static void Main(string[] args)
        {
            RegEX regEX = new RegEX();
            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();
            if (regEX.FirstName.IsMatch(firstName))
            {
                Console.WriteLine("first name is valid");
            }
            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();
            if (regEX.LastName.IsMatch(lastName))
            {
                Console.WriteLine("last name is valid");
            }
            Console.WriteLine("Enter address");
            string address = Console.ReadLine();
            if (regEX.Address.IsMatch(address))
            {
                Console.WriteLine("Address is valid");
            }
            Console.WriteLine("Enter email");
            string email = Console.ReadLine();
            if (regEX.Email.IsMatch(email))
            {
                Console.WriteLine("Email is valid");
            }

        }
    }
}
