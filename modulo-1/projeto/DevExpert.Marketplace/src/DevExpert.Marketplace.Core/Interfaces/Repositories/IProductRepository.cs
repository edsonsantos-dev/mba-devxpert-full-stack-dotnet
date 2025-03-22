using DevExpert.Marketplace.Core.Entities;

namespace DevExpert.Marketplace.Core.Interfaces.Repositories;

public interface IProductRepository : IRepository<Product>
{
    Task<Product?> GetProductByCategoryIdAsync(Guid categoryId);
    Task<Product?> GetProductBySellerIdAsync(Guid sellerId);
}