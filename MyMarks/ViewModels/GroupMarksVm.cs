using MyMarks.Shared.Dtos;

namespace MyMarks.ViewModels;

public class GroupMarksVm
{
    public GroupDto Group { get; set; }
    public List<SubjectDto> Subjects { get; set; }
}