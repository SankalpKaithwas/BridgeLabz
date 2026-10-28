using System;

namespace StopWatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a stopwatch program");
            Console.WriteLine("Press 1 to start the stopwatch");
            Console.WriteLine("Press 2 to stop the stopwatch");
            Console.WriteLine("Press 0 to exit the program");
            StopWatchRun stopwatch = new StopWatchRun();
            int input = -1;
            do
            {
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        stopwatch.Start();
                        break;
                    case 2:
                        stopwatch.Stop();
                        break;
                    case 0:
                        Console.WriteLine("Bye");
                        break;
                }
            } while (input != 0);
        }


    }
}
