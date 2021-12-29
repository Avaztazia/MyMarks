using MyMarks.Shared.Dtos;

namespace MyMarks.ViewModels;

public class IndexPageVm
{
    public TeacherDto Teacher { get; set; }
    public List<GroupDto> Groups { get; set; }
}