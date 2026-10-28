using System;

namespace Conditionls
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;
            switch (season)
            {
                case Season.Autumn:                    
                case Season.Spring:
                    Console.WriteLine("Its Amazing out in the wind");
                    break;
                default: Console.WriteLine("Not perfect wether");
                    break;
            }
            
        }
    }
}
