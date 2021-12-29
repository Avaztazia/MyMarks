namespace MyMarks.Shared.Dtos;

public class MarkDto
{
    public Guid Id { get; set; }
    public decimal Grade { get; set; }
    public StudentDto Student { get; set; }
    public Guid StudentId { get; set; }
    public TeacherDto Teacher { get; set; }
    public Guid TeacherId { get; set; }
    public PairDto Pair { get; set; }
    public Guid PairId { get; set; }
}