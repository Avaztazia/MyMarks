namespace MyMarks.Dal.Entities;

public class Person
{
    public string? OwnerID { get; set; }
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTimeOffset BirthDate { get; set; }
}