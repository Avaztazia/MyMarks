using Microsoft.EntityFrameworkCore;
using MyMarks.Dal.Entities;

namespace MyMarks.Dal.Repositories;

public class GroupRepository : BaseRepository<MyMarksDbContext, Group, Guid>
{
    public GroupRepository(MyMarksDbContext context) : base(context)
    {
    }

    public async Task<Group?> GetByName(string groupName)
    {
        return await Context.Groups.Where(x => x.Name == groupName)
            .Include(x => x.Students)
            .Include(x => x.Subjects).ThenInclude(x => x.Pairs).ThenInclude(x => x.Marks)
            .FirstOrDefaultAsync();
    }

    public async Task<List<Group>> GetGroupsForTeacher(Guid teacherId)
    {
        return await (from g in Context.Groups
            .Include(x => x.Subjects).ThenInclude(x => x.Teacher)
            join s in Context.Subjects on teacherId equals s.Teacher.Id
            select g)
            .ToListAsync();
    }
}