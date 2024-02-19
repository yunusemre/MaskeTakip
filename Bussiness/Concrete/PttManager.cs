using Bussiness.Abstract;
using Entities.Concrete;

namespace Bussiness;

public class PttManager(IApplicantService applicantService) : ISupplierService
{
    public void GiveMask(Person person)
    {
        if (applicantService.CheckPerson(person))
        {
            Console.WriteLine("{0} {1} maskeleme yetkisi verildi!", person.FirstName, person.LastName);
        }
        else
        {
            Console.WriteLine("Maske verilemedi! Lütfen doğru bilgileri giriniz.");
        }
    }
    
}