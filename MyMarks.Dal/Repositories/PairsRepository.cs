using Microsoft.EntityFrameworkCore;
using MyMarks.Dal.Entities;
using MyMarks.Shared.Dtos;

namespace MyMarks.Dal.Repositories;

public class PairsRepository : BaseRepository<MyMarksDbContext, Pair, Guid>
{
    public PairsRepository(MyMarksDbContext context) : base(context)
    {
    }

    public async Task<Pair> AddAsync(PairDto entity)
    {
        var subject = await Context.Subjects
            .Include(x => x.Pairs)
            .FirstOrDefaultAsync(x => x.Id == entity.SubjectId);
        
        var pair = new Pair
        {
            Marks = null,
            PairDateTime = entity.PairDateTime
        };

        await Context.AddAsync(pair);
        subject!.Pairs.Add(pair);
        Context.Update(subject);
        await SaveAsync();
        return pair;
    }
}