using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MernisServiceReference;
using StarbucksAndNeroCofeeDemo.Abstract;


namespace StarbucksAndNeroCofeeDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
