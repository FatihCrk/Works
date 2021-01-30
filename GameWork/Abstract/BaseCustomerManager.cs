using System;
using System.Collections.Generic;
using System.Text;

namespace GameWork.Abstract
{
    class BaseCustomerManager:ICustomerServices
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " İsimli Kullanıcının Database'e Kaydı Gerçekleştirildi..");
        }
    }
}
