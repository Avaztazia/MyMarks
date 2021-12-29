using System.ComponentModel.DataAnnotations.Schema;
using MyMarks.Dal.Enums;

namespace MyMarks.Dal.Entities;

public class Student : Person
{
    public Group Group { get; set; }
    [ForeignKey(nameof(Group))]
    public Guid GroupId { get; set; }
    public StudingFormDb Form { get; set; }
}