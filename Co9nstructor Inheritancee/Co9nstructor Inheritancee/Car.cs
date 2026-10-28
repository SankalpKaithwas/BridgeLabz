using System;

namespace Co9nstructor_Inheritancee
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            :base(registrationNumber)
        {
            Console.WriteLine("Car is Being Initialised. {0}" , registrationNumber);
        }
    }
}
