using System;
using StarbucksAndNeroCofeeDemo.Abstract;
using StarbucksAndNeroCofeeDemo.Concrete;

namespace StarbucksAndNeroCofeeDemo
{
    class Program
    {
        static void Main(string[] args)
        {BaseCustomerManager customerManager = new StarbucksCustomerManager(new CustomerCheckManager());
        customerManager.Save(new Customer{DateOfBirth = new DateTime( 1993,2,16), FirstName = "Fatih", LastName = "ÇIRAK", NationalityId = "1234567890" });
             
        }
    }
}
