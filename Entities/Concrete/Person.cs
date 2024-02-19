namespace Entities.Concrete;

public class Person
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required long NationalIdentity { get; set; }
    public required int DateOfBirthYear { get; set; }
}