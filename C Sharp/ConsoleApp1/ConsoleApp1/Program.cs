using Enum;
namespace Enum
{
    public enum Seasons
    {
        winter = 1,
        summer = 2,
        spring = 3,
        Autumn = 4
    }
    public class Program
    {


        public static void Main(string[] args)
        {
            Console.WriteLine((int)Seasons.summer);

            foreach (int item in Enum.GetName(typeof(Seasons)))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(Enum.ge);
        }
    }
}