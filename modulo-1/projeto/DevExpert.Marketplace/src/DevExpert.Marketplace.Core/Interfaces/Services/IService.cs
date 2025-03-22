using DevExpert.Marketplace.Core.Entities.AuditableEntities;

namespace DevExpert.Marketplace.Core.Interfaces.Services;

public interface IService<TEntity> : IDisposable where TEntity : Entity
{
    Task<TEntity?> AddAsync(TEntity entity);
    Task<TEntity?> GetByIdAsync(Guid id);
    Task<List<TEntity>> GetAllAsync();
    Task<TEntity?> UpdateAsync(TEntity entity);
    Task<bool> RemoveAsync(Guid id);
}