using System;
using System.IO;

namespace Directoryand
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("path");  //static method
            var files = Directory.GetFiles("path", "searchPattern", SearchOption.AllDirectories);
            foreach(var file in files)
                Console.WriteLine(file);


            var directories = Directory.GetDirectories("path", "serchpattern", SearchOption.AllDirectories);
            foreach(var directory in directories)
                Console.WriteLine(directory);

            Directory.Exists("path");


            var directoryInfo = new DirectoryInfo("path");      //instance method
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();

        }
    }
}
