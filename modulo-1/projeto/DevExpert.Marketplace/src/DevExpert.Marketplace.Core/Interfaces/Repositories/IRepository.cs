using System.Linq.Expressions;
using DevExpert.Marketplace.Core.Entities.AuditableEntities;

namespace DevExpert.Marketplace.Core.Interfaces.Repositories;

public interface IRepository<TEntity> : IDisposable where TEntity : Entity 
{
    Task AddAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task<bool> RemoveAsync(Guid id);
    Task<TEntity?> GetByIdAsync(Guid id);
    Task<List<TEntity>> GetAllAsync();
    Task<IEnumerable<TEntity>> SearchAsync(Expression<Func<TEntity, bool>> predicate);
    Task<int> SaveChangesAsync();
}