using MyMarks.Dal.Entities;

namespace MyMarks.Dal.Repositories;

public class TeachersRepository : BaseRepository<MyMarksDbContext, Teacher, Guid>
{
    public TeachersRepository(MyMarksDbContext context) : base(context)
    {
    }
}