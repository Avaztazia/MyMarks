namespace MyMarks.Models;

public class SaveMarkModel
{
    public Guid StudentId { get; set; }
    public Guid TeacherId { get; set; }
    public Guid PairId { get; set; }
    public decimal Grade { get; set; }

    public void EnsureValid()
    {
        if (StudentId == default) throw new ArgumentNullException("StudentId");
        if (TeacherId == default) throw new ArgumentNullException("TeacherId");
        if (PairId == default) throw new ArgumentNullException("PairId");
    }
}