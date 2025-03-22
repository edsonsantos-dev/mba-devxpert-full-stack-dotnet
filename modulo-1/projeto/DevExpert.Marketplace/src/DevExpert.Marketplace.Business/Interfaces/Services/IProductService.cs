using DevExpert.Marketplace.Business.Entities;

namespace DevExpert.Marketplace.Business.Interfaces.Services;

public interface IProductService : IService<Product>
{
    Task<Product?> GetProductByCategoryIdAsync(Guid categoryId);
    Task<Product?> GetProductBySellerIdAsync(Guid sellerId);
    Task<Product?> UpdateStockAsync(int stock, Guid id);
    Task<Product?> UpdatePriceAsync(int price, Guid id);
}