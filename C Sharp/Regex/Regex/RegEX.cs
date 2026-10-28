using System;
using System.Text.RegularExpressions;

namespace Rege
{
    public class RegEX
    {
        public Regex FirstName = new Regex(@"^[A-Z][A-Z a-z]{3,}$");
        public void Validate(string firstName)
        {
            if (FirstName.IsMatch(firstName))
            {
                Console.WriteLine($"{firstName} is Valid");
            }
            else
            {
                Console.WriteLine($"{firstName} is Invalid");
            }
        }
        public Regex Name = new Regex(@"^[A-Z a-z]{3,}\s[A-Z a-z]{3,}$");
        public void ValidateLastName(string name)
        {
            if (Name.IsMatch(name))
            {
                Console.WriteLine($"{name} is Valid");
            }
            else
            {
                Console.WriteLine($"{name} is Invalid");
            }
        }
    }
}
