namespace MyMarks.Shared.Dtos;

public class TeacherDto : PersonDto
{
    public string Faculty { get; set; }
    public List<SubjectDto> Subjects { get; set; }
    public List<GroupDto> GroupDtos { get; set; }
}