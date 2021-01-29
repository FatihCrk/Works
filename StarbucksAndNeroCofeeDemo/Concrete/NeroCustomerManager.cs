using System;
using System.Collections.Generic;
using System.Text;
using StarbucksAndNeroCofeeDemo.Abstract;

namespace StarbucksAndNeroCofeeDemo.Concrete
{
    public class NeroCustomerManager : BaseCustomerManager
    {
        public ICustomerCheckService _customerCheckService;

        public NeroCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }


        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Geçerli Bir Kişi Değil.");
            }


        }
    }
}
