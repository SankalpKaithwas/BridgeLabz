using System;

namespace School_management_system
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to School");
            Console.WriteLine("Please select what you want to do form the options below");


            while (true)
            {
                int operation = InputUtil.enterInteger("1. Register students \n2. Show all Students \n3. Find students \n4. Modify students \n5. Exit");
                if (operation == 1)
                {
                    MenuUtil.registerStudent();
                }
                if (operation == 2)
                {
                    MenuUtil.showStudents();
                }
                else if (operation == 3)
                {
                    MenuUtil.findStudent();
                }
                else if (operation == 4)
                {
                    MenuUtil.modifyStudents();
                }
                else if (operation == 5)
                {
                    Console.WriteLine("Exiting..");
                    Environment.Exit(0);
                }

            }

        }

    }
}
