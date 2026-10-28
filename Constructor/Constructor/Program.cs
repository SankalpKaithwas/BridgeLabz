using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer("Sankalp",1 );
            var order = new Order();
            customer.Orders.Add(order);
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);


        }
    }
}
