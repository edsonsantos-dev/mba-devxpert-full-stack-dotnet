using DevExpert.Marketplace.Business.Entities;

namespace DevExpert.Marketplace.Business.Interfaces.Repositories;

public interface IProductRepository : IRepository<Product>
{
    Task<Product?> GetProductByCategoryIdAsync(Guid categoryId);
    Task<Product?> GetProductBySellerIdAsync(Guid sellerId);
}