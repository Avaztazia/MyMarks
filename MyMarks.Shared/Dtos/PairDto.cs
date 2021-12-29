namespace MyMarks.Shared.Dtos;

public class PairDto
{
    public Guid Id { get; set; }
    public DateTimeOffset PairDateTime { get; set; }
    public Guid SubjectId { get; set; }
    public List<MarkDto> Marks { get; set; }
}