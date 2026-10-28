using System;

namespace Enasdasdasd
{
    public enum Seasons
    {
        winter = 1,
        summer = 2,
        spring = 67,
        Autumn
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine((int)Seasons.summer);

            //GET  enum names
            foreach (string item in Enum.GetNames(typeof(Seasons)))
                Console.WriteLine(item);

            // GET constatnt values
            foreach (Seasons item in Enum.GetValues(typeof(Seasons)))
                Console.WriteLine(item); 
            
            // GET constatnt values
            foreach (Seasons item in Enum.GetValues(typeof(Seasons)))
                Console.WriteLine((int)item); 
            
            foreach (int item in Enum.GetValues(typeof(Seasons)))
                Console.WriteLine(item);

            //GET values with name
            foreach (Seasons item in Enum.GetValues(typeof(Seasons)))
                Console.WriteLine($"{item} = {(int)item}");

            Console.WriteLine("Season = " + Seasons.winter);
            Console.WriteLine("Winter is " + (int)Seasons.winter);
        }
    }
}
