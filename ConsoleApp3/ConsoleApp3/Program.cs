using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static string Solution(string input)
        {
            
            char[] chars = input.ToCharArray();
            int[] array = new int[input.Length];
            for (int i = 0; i < chars.Length; i++)
            {
                array[i] = (int)chars[i];
            }
            char[] chars2 = new char[input.Length];
            for(int j = 0;j< array.Length; j++)
            {
                int a = array[j];
                if (a != 122) { 
                chars2[j] = (char) (a+1);}
                else chars2[j] = (char) (97);
            }
            string result = new string(chars2);

            return result;
        }

       static int sol(int n,int k)
        {
            

            double d = Math.Pow(n, k);
            int a = (int)Math.Pow(10, 7) + 7;
            int res = (int)d % a;
            return Math.Abs(res);
        }
        static void Main(string[] args)
        {
            string res = Solution("crazy");
            Console.WriteLine(res);
            Console.WriteLine((int)'a');
            Console.WriteLine(sol(2000,1000));
        }
    }
}
