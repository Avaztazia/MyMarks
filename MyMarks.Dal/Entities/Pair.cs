namespace MyMarks.Dal.Entities;

public class Pair
{
    public Guid Id { get; set; }
    public DateTimeOffset PairDateTime { get; set; }
    public List<Mark> Marks { get; set; }
}