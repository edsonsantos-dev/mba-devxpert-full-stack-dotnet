using DevExpert.Marketplace.Core.Entities;
using DevExpert.Marketplace.Core.Interfaces;
using DevExpert.Marketplace.Core.Interfaces.Repositories;
using DevExpert.Marketplace.Core.Interfaces.Services;

namespace DevExpert.Marketplace.Core.Services;

public class ProductService(IProductRepository repository, INotifier notifier)
    : Service<Product>(repository, notifier), IProductService
{
    public async Task<Product?> GetProductByCategoryIdAsync(Guid categoryId)
    {
        return await repository.GetProductByCategoryIdAsync(categoryId);
    }

    public async Task<Product?> GetProductBySellerIdAsync(Guid sellerId)
    {
        return await repository.GetProductBySellerIdAsync(sellerId);
    }

    public async Task<Product?> UpdateStockAsync(int stock, Guid id)
    {
        var product = await repository.GetByIdAsync(id);

        if (product == null)
        {
            notifier.AddNotification(new("Product not found."));
            return null;
        }

        if (product.UpdateStock(stock, notifier))
        {
            await repository.UpdateAsync(product);
            await repository.SaveChangesAsync();
        }

        return product;
    }

    public async Task<Product?> UpdatePriceAsync(int price, Guid id)
    {
        var product = await repository.GetByIdAsync(id);

        if (product == null)
        {
            notifier.AddNotification(new("Product not found."));
            return null;
        }

        if (product.UpdateStock(price, notifier))
        {
            await repository.UpdateAsync(product);
            await repository.SaveChangesAsync();
        }

        return product;
    }
}