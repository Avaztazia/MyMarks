namespace MyMarks.Shared.Dtos;

public class GroupDto
{
    public Guid Id { get; set; }
    public int Course { get; set; }
    public string Faculty { get; set; }
    public string Name { get; set; }
    public List<StudentDto> Students { get; set; }
    public List<SubjectDto> Subjects { get; set; }
}