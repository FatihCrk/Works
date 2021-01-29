using System;
using System.Collections.Generic;
using System.Text;
using StarbucksAndNeroCofeeDemo.Abstract;


namespace StarbucksAndNeroCofeeDemo.Concrete
{
    public class StarbucksCustomerManager:BaseCustomerManager 
    {
        public ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
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
