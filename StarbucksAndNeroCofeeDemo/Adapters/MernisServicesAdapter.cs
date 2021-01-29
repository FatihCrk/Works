using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MernisServiceReference;
using StarbucksAndNeroCofeeDemo.Abstract;

namespace StarbucksAndNeroCofeeDemo.Adapters
{
    public class MernisServicesAdapter//:ICustomerCheckService //MERNIS BİLGİSİ CANLIDA BU ŞEKİLDE ÇAĞIRILIR
    //FAKAT Localde servis çalışmaz vs. gibi durumlar için biz fake bir servis ile kontrol ederiz.
    {
        //public bool CheckIfRealPerson(Customer customer)
        //{
        //    KPSPublicSoapClient client = new KPSPublicSoapClient();
        //    return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), 
        //        customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);
        //}
    }
}
