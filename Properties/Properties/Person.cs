using System;

namespace Properties
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime Birthdate { get; private set; }     //propery (Read Only), Auto Implementing 

        public Person(DateTime birthdate)       //Constructor
        {
            Birthdate = birthdate;
        }
       
        public int Age              //Property
        {
            get
            {
               var timespan =  DateTime.Today - Birthdate;
                var years = timespan.Days / 365;

                return years;

            }
        }


    }
}
