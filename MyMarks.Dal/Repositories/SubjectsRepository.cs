using Microsoft.EntityFrameworkCore;
using MyMarks.Dal.Entities;

namespace MyMarks.Dal.Repositories;

public class SubjectsRepository : BaseRepository<MyMarksDbContext, Subject, Guid>
{
    public SubjectsRepository(MyMarksDbContext context) : base(context)
    {
    }

    public async Task<List<Subject>> GetByStudentIdAsync(Guid studentId)
    {
        return await Context.Subjects
            .Include(x => x.Pairs).ThenInclude(x => x.Marks).ThenInclude(x => x.Teacher)
            .Include(x => x.Group)
            .Where(x => x.Group.Students
                .Select(x => x.Id)
                .Contains(studentId))
            .ToListAsync();
    }

    public async Task<List<Subject>> GetByGroupName(string groupName)
    {
        return await Context.Subjects
            .Include(x => x.Pairs).ThenInclude(x => x.Marks).ThenInclude(x => x.Teacher)
            .Include(x => x.Group)
            .Include(x => x.Teacher)
            .Where(x => x.Group.Name == groupName)
            .ToListAsync();
    }

    public async Task<List<Subject>> GetByGroupId(Guid groupId)
    {
        return await Context.Subjects
            .Include(x => x.Teacher)
            .Include(x => x.Pairs).ThenInclude(x => x.Marks).ThenInclude(x => x.Teacher)
            .Where(x => x.Group.Id == groupId)
            .ToListAsync();
    }
}