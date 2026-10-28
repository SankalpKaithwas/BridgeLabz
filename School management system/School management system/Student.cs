namespace School_management_system
{
    public class Student
    {
        private string name;
        private int age;
        private string standard;

        public Student()
        {
        }

        public Student(string name, int age, string standard)
        {
            this.name = name;
            this.age = age;
            this.standard = standard;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }
        public string Name
        {
            get { return name; }
            set { Name = value; }
        }

        public string Standard
        {
            get { return standard; }
            set { Standard = value; }
        }


        public string info()
        {
            return "name: " + Name + ", age: " + Age + ", Satandard: " + Standard;
        }
    }
}




