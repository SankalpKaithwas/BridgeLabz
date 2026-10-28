using System.Collections.Generic;

namespace Constructor
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;
        public Customer()  //empty constructor
        {
            Orders = new List<Order>();             //list initialisation
        }
        public Customer(int id)         //constructor with one parameter
            :this()
        {
            this.Id = id;
        }
        public Customer(string name, int id)        //constructor with two parameter
            : this(id)
        {
            
            this.Name = name;
        }

    }
}
