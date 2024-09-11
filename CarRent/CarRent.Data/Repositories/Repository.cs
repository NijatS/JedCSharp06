using CarRent.Context;
using CarRent.Data.Exceptions;
using CarRent.Models.BaseEntities;
using CarRent.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CarRent.Repositories;

public class Repository<T> : IRepository<T> where T : BaseEntity
{
    private readonly CarRentDbContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(CarRentDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public async Task<bool> AddAsync(T entity)
    {
        EntityEntry entityEntry = await _dbSet.AddAsync(entity);
        return entityEntry.State == EntityState.Added;
    }

    public async Task AddRangeAsync(IEnumerable<T> entities)
        => await _dbSet.AddRangeAsync(entities);

    public bool Update(T entity)
    {
        EntityEntry entityEntry = _dbSet.Update(entity);
        return entityEntry.State == EntityState.Modified;
    }

    public void UpdateRange(IEnumerable<T> entities)
        => _dbSet.UpdateRange(entities);

    public bool Remove(T entity)
    {
        EntityEntry entityEntry = _dbSet.Remove(entity);
        return entityEntry.State == EntityState.Deleted;
    }

    public async Task<bool> RemoveAsync(int id)
    {
        var entity = await GetAsync(id);
        EntityEntry entityEntry = _dbSet.Remove(entity);
        return entityEntry.State == EntityState.Deleted;
    }

    public void RemoveRange(IEnumerable<T> entities)
        => _dbSet.RemoveRange(entities);


    public async Task<T> GetAsync(int id)
    {
        var entity = await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
        if (entity is null)
            throw new EntityNotFoundException();

        return entity;
    }

    public IQueryable<T> GetAll()
    {
        return _dbSet;
    }

    public int Save()
        => _context.SaveChanges();

    public async Task<int> SaveAsync()
        => await _context.SaveChangesAsync();
}