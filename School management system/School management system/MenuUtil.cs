using System;
using System.Collections.Generic;
using System.Text;

namespace School_management_system
{
    class MenuUtil
    {
        public static void registerStudent()
        {
            int count = InputUtil.enterInteger("How many students do you want to Register: ");
            Array_students.students = new Student[count];       //important logic
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine((i + 1) + ". Registration:");
                Student st = InputUtil.fillStudent();
                Array_students.students[i] = st;
            }
        }

        public static void showStudents()
        {
            if (Array_students.students == null)
            {
                Console.WriteLine("No students are registered yet");
            }
            else Console.WriteLine("Registered students are:");
            {
                for (int i = 0; i < Array_students.students.Length; i++)
                {
                    Student st = Array_students.students[i];        // important logic
                    Console.WriteLine((i + 1) + ". Student: " + st.info());
                }
            }
        }

        public static void findStudent()
        {
            string find = InputUtil.enterString("Enter name of student: ");
            for (int i = 0; i < Array_students.students.Length; i++)
            {
                Student st = Array_students.students[i];
                if (st.Name.Equals(find, StringComparison.CurrentCultureIgnoreCase))        //method ignore case
                {
                    Console.WriteLine(st.info());
                }
            }
        }
        public static void modifyStudents()
        {
            int student_number = InputUtil.enterInteger("What students you want to modify/update: ");
            Console.WriteLine("Enter students new information: ");
            Student st = InputUtil.fillStudent();
            Array_students.students[student_number - 1] = st;
            Console.WriteLine(st.info());
        }
    }
}
