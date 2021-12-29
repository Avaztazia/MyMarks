namespace MyMarks.Dal.Repositories;

public interface IBaseRepository<TEntity, in TKey>
{
    Task<TEntity> AddAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task<TEntity> DeleteAsync(TEntity entity);
    Task<TEntity?> GetByIdAsync(TKey id);
    Task<int> GetCountAsync();
    Task<List<TEntity>> PagingFetchAsync(int startIndex, int count);
    Task SaveAsync();
}