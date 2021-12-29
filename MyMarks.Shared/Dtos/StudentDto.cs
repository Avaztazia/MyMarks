using System.ComponentModel.DataAnnotations;
using MyMarks.Shared.Enums;

namespace MyMarks.Shared.Dtos;

public class StudentDto : PersonDto
{
    public GroupDto? Group { get; set; }
    public Guid GroupId { get; set; }
    public StudingForm Form { get; set; }
}