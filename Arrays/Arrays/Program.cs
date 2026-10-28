using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 3,4,5,6,7,8};
            //Length
            Console.WriteLine("length: " + numbers.Length);

            //IndexOf()           
            var index = Array.IndexOf(numbers,8);
            Console.WriteLine("index of 8 : " + index);

            //Clear()
            Array.Clear(numbers, 2, 3);//2 se chalu hoga or 3 elements clear karega
            Console.WriteLine("After clear: ");
            foreach(var n in numbers)
                Console.WriteLine(n);

            //Copy()
            int[] another = new int[3];
            Array.Copy(numbers,another,3);
            Console.WriteLine( "Effect of copy:");
            foreach(var n in another)
            Console.WriteLine(n);

            //Sort()
            Array.Sort(another);
            Console.WriteLine( "After sorting: ");
            foreach(var n in another)
                Console.WriteLine(n);

            //REverse()
            Array.Reverse(another);
            Console.WriteLine("After Rverse: ");
            foreach(var n in another)
                Console.WriteLine(n);
        }
    }
}
