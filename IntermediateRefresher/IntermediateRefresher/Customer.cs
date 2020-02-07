using System;
using System.Collections.Generic;
using System.Text;

namespace IntermediateRefresher
{
    class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();
        public Customer()
        {
        }

        public Customer(int id)
            : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            //Orders = new List<Order>();
        }


        public static void Run()
        {
            var customer = new Customer();
            customer.Id = 1;
            customer.Name = "Cee";
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            customer.Promote();
        }
    }
}
