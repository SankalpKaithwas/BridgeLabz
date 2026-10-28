using System;
using System.Collections.Generic;
using System.Text;

namespace School_management_system
{
    class InputUtil
    {
        public static int enterInteger(string title)
        {
            Console.WriteLine(title);
            int operation = int.Parse(Console.ReadLine());
            return operation;
        }
        public static string enterString(string title)
        {
            Console.WriteLine(title);
            string answer = Console.ReadLine();
            return answer;
        }
        public static Student fillStudent()
        {
            string name = InputUtil.enterString("Enter students name: ");
            int age = InputUtil.enterInteger("Ener age of student: ");
            string standard = InputUtil.enterString("Enter students standard:");
            //Student student = new Student(name, age, standard);       student object
            //return student;
            return new Student(name, age, standard);
        }
    }
}
