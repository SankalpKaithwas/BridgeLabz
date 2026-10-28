using System;

namespace Inheritance
{
    public class PresentationObject
    {
        public int width { get; set; }
        public int height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Copied");
        }
        public void Duplicate()
        {
            Console.WriteLine("Duplicated");
        }


    }
}
