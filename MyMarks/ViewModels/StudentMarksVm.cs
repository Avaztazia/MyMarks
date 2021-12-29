using MyMarks.Shared.Dtos;

namespace MyMarks.ViewModels;

public class StudentMarksVm
{
    public StudentDto Student { get; set; }
    public List<SubjectDto> Subjects { get; set; }
}