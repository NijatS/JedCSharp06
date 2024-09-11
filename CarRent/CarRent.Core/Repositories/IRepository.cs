using CarRent.Models.BaseEntities;

namespace CarRent.Repositories.Interfaces;

public interface IRepository<T> where T : BaseEntity
{
    Task<bool> AddAsync(T entity);
    Task AddRangeAsync(IEnumerable<T> entities);
    bool Update(T entity);
    void UpdateRange(IEnumerable<T> entities);
    bool Remove(T entity);
    Task<bool> RemoveAsync(int id);
    void RemoveRange(IEnumerable<T> entities);
    Task<T> GetAsync(int id);
    IQueryable<T> GetAll();
    int Save();
    Task<int> SaveAsync();
}