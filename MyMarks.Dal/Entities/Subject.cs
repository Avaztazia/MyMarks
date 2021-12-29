namespace MyMarks.Dal.Entities;

public class Subject
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Credits { get; set; }
    public List<Pair> Pairs { get; set; }
    public Group Group { get; set; }
    public Teacher Teacher { get; set; }
}