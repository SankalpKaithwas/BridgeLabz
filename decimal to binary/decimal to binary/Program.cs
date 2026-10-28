using System;

namespace decimal_to_binary
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Decimal: ");
            int decimalNumber = int.Parse(Console.ReadLine());

            int remainder;
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;     
            }
            Console.WriteLine("Binary:  {0}", result);          // ($"Binary : {result}")
        }
    }
}
