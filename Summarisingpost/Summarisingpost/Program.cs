using System;
using System.Collections.Generic;

namespace Summarisingpost
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "The key is this idea called the paradox of skill. As people become better at an activity, the difference between the best and the average and the best and the worst becomes much narrower. As people become more skillful, luck becomes more important. That’s precisely what happens in the world of investing.";
            var summary = stringUtility.SummerizeText(sentence,25);
            Console.WriteLine(summary);
            
        }
        
    }
}
