using Microsoft.EntityFrameworkCore;
using MyMarks.Dal.Entities;
using MyMarks.Shared.Dtos;

namespace MyMarks.Dal.Repositories;

public class MarksRepository : BaseRepository<MyMarksDbContext, Mark, Guid>
{
    public MarksRepository(MyMarksDbContext context) : base(context)
    {
    }

    public async Task<Mark> GetMarkForStudentByPairId(Guid pairId, Guid studentId)
    {
        return await Context.Pairs
            .Where(x => x.Id == pairId)
            .Select(x => x.Marks.FirstOrDefault(x => x.Student.Id == studentId))
            .FirstOrDefaultAsync();
    }
}