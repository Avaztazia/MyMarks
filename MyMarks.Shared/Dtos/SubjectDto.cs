namespace MyMarks.Shared.Dtos;

public class SubjectDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Credits { get; set; }
    public List<PairDto> Pairs { get; set; }
    public GroupDto Group { get; set; }
    public TeacherDto Teacher { get; set; }
}