using System;

namespace Basic_core_Programs
{
    internal class FlipCoin
    {
        public void FlipCoinPercentage(int number)
        {
            int headCount = 0;
            int tailCount = 0;
            if (number > 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    int checkToss = new Random().Next(0, 2);
                    if (checkToss == 0)
                    {
                        headCount++;
                    }
                    else
                    {
                        tailCount++;
                    }
                }
                double headPercent = (double)headCount / number * 100;
                double tailPercent = (double)tailCount / number * 100;
                Console.WriteLine("Head percentage is -> " + Math.Round(headPercent, 1));
                Console.WriteLine("Tail percentage is -> " + Math.Round(tailPercent, 1));
            }
            else
            {
                Console.WriteLine("Enter a Positive integer");
            }
        }
    }
}