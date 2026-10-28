using System;

namespace Date_And_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating
            var timespan = new TimeSpan(1, 2, 3);
            var timespan2 = new TimeSpan(1, 0, 0);
            var timeSpan3 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine(duration);

            //Properties
            Console.WriteLine("Minutes: "  + timespan.Minutes);
            Console.WriteLine("Total minuts: " + timespan.TotalMinutes);

            //add
            Console.WriteLine("Add: " + timespan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract: " + timespan.Subtract(TimeSpan.FromMinutes(8)));

            //Tostring
            Console.WriteLine("Tostring: " + timespan.ToString());

            //parse
            Console.WriteLine("Parse: "  + TimeSpan.Parse("01:02:03"));


        }
    }
}
