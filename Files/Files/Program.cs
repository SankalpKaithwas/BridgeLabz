using System;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Copy("sourece", "destination", true);
            File.Delete("path");
            if (File.Exists("Path"))
            {
                //
            }
            string content = File.ReadAllText("path");  //File is static method

            var fileInfo = new FileInfo("Path");    //instance method
            fileInfo.CopyTo("");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }
        }
    }
}
