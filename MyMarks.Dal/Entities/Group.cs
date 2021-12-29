namespace MyMarks.Dal.Entities;

public class Group
{
    public Guid Id { get; set; }
    public int Course { get; set; }
    public string Faculty { get; set; }
    public string Name { get; set; }
    public List<Student> Students { get; set; }
    public List<Subject> Subjects { get; set; }
}