namespace MyMarks.Dal.Entities;

public class Teacher : Person
{
    public string Faculty { get; set; }
    public List<Subject> Subjects { get; set; }
    public List<Group> Groups { get; set; }
}