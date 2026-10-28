using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var num = int.Parse("abc");

            }
            catch (Exception)
            {

                Console.WriteLine("Conversion Failed"); ;
            }
            int number;
            var result = int.TryParse("abc", out number);
            if (result)
                Console.WriteLine(number);
            else Console.WriteLine("Conversion Failed");

        }
        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4 }));
        }
        static void usePoints()
        {
            try
            {
                var point = new Point(30, 40);
                point.Move(null);
                Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);

                point.Move(10, 20);
                Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);

            }
            catch (Exception)
            {

                Console.WriteLine("Unexpected Error");
            }
        }
    }
}
