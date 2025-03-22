using System.Linq.Expressions;
using DevExpert.Marketplace.Business.Entities.AuditableEntities;
using DevExpert.Marketplace.Business.Interfaces.Repositories;
using DevExpert.Marketplace.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DevExpert.Marketplace.Data.Repositories;

public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
{
    protected readonly MarketplaceContext Context;
    protected readonly DbSet<TEntity> DbSet;

    protected Repository(MarketplaceContext context, DbSet<TEntity> dbSet)
    {
        Context = context;
        DbSet = dbSet;
    }

    public virtual async Task AddAsync(TEntity entity)
    {
        await DbSet.AddAsync(entity);
    }

    public virtual async Task UpdateAsync(TEntity entity)
    {
        await Task.Run(() => { DbSet.Update(entity); });
    }

    public virtual async Task<bool> RemoveAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);

        if (entity == null)
            return false;

        DbSet.Remove(entity);
        return true;
    }

    public virtual async Task<TEntity?> GetByIdAsync(Guid id)
    {
        return await DbSet.FindAsync(id);
    }

    public virtual async Task<List<TEntity>> GetAllAsync()
    {
        return await DbSet
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<IEnumerable<TEntity>> SearchAsync(Expression<Func<TEntity, bool>> predicate)
    {
        return await DbSet
            .AsNoTracking()
            .Where(predicate)
            .ToListAsync();
    }

    public async Task<int> SaveChangesAsync()
    {
        return await Context.SaveChangesAsync();
    }

    public void Dispose()
    {
        Context.Dispose();
    }
}