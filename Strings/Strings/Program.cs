using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Sankalp Kaithwas ";
            Console.WriteLine("Trim : '{0}'",fullName.Trim());
            Console.WriteLine("ToUpper : '{0}'",fullName.ToUpper());


            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("firstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);


            Console.WriteLine(fullName.Replace("S", "s")); 

            if(string.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");


            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);


            float price = 29.98f;
            Console.WriteLine(price.ToString("C0")); 
            
        }
    }
}
