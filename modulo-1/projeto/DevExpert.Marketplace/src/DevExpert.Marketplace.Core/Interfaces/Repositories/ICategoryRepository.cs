using DevExpert.Marketplace.Core.Entities;

namespace DevExpert.Marketplace.Core.Interfaces.Repositories;

public interface ICategoryRepository : IRepository<Category>
{
    Task<Category?> GetCategoryWithProductsAsync(Guid id);
}