using System.ComponentModel.DataAnnotations.Schema;

namespace MyMarks.Dal.Entities;

public class Mark
{
    public Guid Id { get; set; }
    public decimal Grade { get; set; }
    public Student Student { get; set; }
    [ForeignKey(nameof(Student))]
    public Guid StudentId { get; set; }
    public Teacher Teacher { get; set; }
    [ForeignKey(nameof(Teacher))]
    public Guid TeacherId { get; set; }
    public Pair Pair { get; set; }
    [ForeignKey(nameof(Pair))]
    public Guid PairId { get; set; }
}