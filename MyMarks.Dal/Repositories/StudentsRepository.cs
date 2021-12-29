using MyMarks.Dal.Entities;

namespace MyMarks.Dal.Repositories;

public class StudentsRepository : BaseRepository<MyMarksDbContext, Student, Guid>
{
    public StudentsRepository(MyMarksDbContext context) : base(context)
    {
    }
}