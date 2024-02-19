using Bussiness;
using Bussiness.Concrete;
using Entities.Concrete;

// create person variable
Person person = new Person
{
    FirstName = "Yunus Emre",
    LastName = "Tatar",
    DateOfBirthYear = 1987,
    NationalIdentity = 36
};
Console.WriteLine("{0} {1}", person.FirstName, person.LastName);

// ================================================ 

Person otherPerson = new Person
{
    FirstName = "YUNUS EMRE",
    LastName = "TATAR",
    DateOfBirthYear = 1987,
    NationalIdentity = 36
};

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(otherPerson);