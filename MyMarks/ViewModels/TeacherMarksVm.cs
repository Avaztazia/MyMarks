using MyMarks.Shared.Dtos;

namespace MyMarks.ViewModels;

public class TeacherMarksVm
{
    public GroupDto Group { get; set; }
    public List<SubjectDto> Subjects { get; set; }
}