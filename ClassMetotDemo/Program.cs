using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {


            Customer customer = new Customer(){ Id =1, Name = "Fatih", Lastname = "Cirak"};
            
            Customer customer2 = new Customer(){ Id = 2, Name = "Yekta", Lastname = "Cirak" };

            
            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer);
           customerManager.Add(customer2);

           customerManager.Updated(customer);
           customerManager.Updated(customer2);


            customerManager.Deleted(customer);
            customerManager.Deleted(customer2);



        }

        






    }
}
