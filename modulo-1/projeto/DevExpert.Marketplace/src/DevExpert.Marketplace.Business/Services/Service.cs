using DevExpert.Marketplace.Business.Entities.AuditableEntities;
using DevExpert.Marketplace.Business.Interfaces;
using DevExpert.Marketplace.Business.Interfaces.Repositories;
using DevExpert.Marketplace.Business.Interfaces.Services;

namespace DevExpert.Marketplace.Business.Services;

public class Service<TEntity>(
    IRepository<TEntity> repository,
    INotifier notifier) : IService<TEntity> where TEntity : Entity
{
    public virtual async Task<TEntity?> AddAsync(TEntity entity)
    {
        if (notifier.HaveNotification())
            return null;
        
        await repository.AddAsync(entity);
        await repository.SaveChangesAsync();
        
        return entity;
    }

    public virtual async Task<TEntity?> GetByIdAsync(Guid id)
    {
        return await repository.GetByIdAsync(id);
    }

    public virtual async Task<List<TEntity>> GetAllAsync()
    {
        return await repository.GetAllAsync();
    }

    public virtual async Task<TEntity?> UpdateAsync(TEntity entity)
    {
        if (notifier.HaveNotification())
            return null;
        
        await repository.UpdateAsync(entity);
        await repository.SaveChangesAsync();
        
        return entity;
    }

    public virtual async Task<bool> RemoveAsync(Guid id)
    {
        if(await repository.RemoveAsync(id))
        {
            await repository.SaveChangesAsync();
            return true;
        }
        
        notifier.AddNotification(new($"Entity with id {id} not found."));
        
        return false;
    }


    public void Dispose()
    {
        repository?.Dispose();
    }
}