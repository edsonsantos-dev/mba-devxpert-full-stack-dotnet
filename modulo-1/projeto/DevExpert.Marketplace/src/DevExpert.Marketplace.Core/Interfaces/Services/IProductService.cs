using DevExpert.Marketplace.Core.Entities;

namespace DevExpert.Marketplace.Core.Interfaces.Services;

public interface IProductService : IService<Product>
{
    Task<Product?> GetProductByCategoryIdAsync(Guid categoryId);
    Task<Product?> GetProductBySellerIdAsync(Guid sellerId);
    Task<Product?> UpdateStockAsync(int stock, Guid id);
    Task<Product?> UpdatePriceAsync(int price, Guid id);
}