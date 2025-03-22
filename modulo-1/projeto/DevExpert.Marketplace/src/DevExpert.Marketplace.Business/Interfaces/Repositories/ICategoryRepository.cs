using DevExpert.Marketplace.Business.Entities;

namespace DevExpert.Marketplace.Business.Interfaces.Repositories;

public interface ICategoryRepository : IRepository<Category>
{
    Task<Category?> GetCategoryWithProductsAsync(Guid id);
}