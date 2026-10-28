using System;

namespace Co9nstructor_Inheritancee
{
    public class Vehicle
    {
        private readonly string _registraionNumber;

        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is being initialised");
        //}
        public Vehicle(string registrationNumber)
        {
            _registraionNumber = registrationNumber;
            Console.WriteLine("Vehicle is being initialised, {0}", registrationNumber);


        }
    }
}
