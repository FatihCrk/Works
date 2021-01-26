using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name + " " +"Customer Added");
        }

        public void Updated(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + "Customer Updated");
        }

        public void Deleted(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + "Customer Deleted");
        }


    }




}
