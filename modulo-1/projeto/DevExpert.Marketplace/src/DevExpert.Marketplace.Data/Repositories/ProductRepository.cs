using DevExpert.Marketplace.Core.Entities;
using DevExpert.Marketplace.Core.Interfaces.Repositories;
using DevExpert.Marketplace.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DevExpert.Marketplace.Data.Repositories;

public class ProductRepository(MarketplaceContext context, DbSet<Product> dbSet)
    : Repository<Product>(context, dbSet), IProductRepository
{
    public async Task<Product?> GetProductByCategoryIdAsync(Guid categoryId)
    {
        return await dbSet
            .AsNoTracking()
            .Include(x => x.Category)
            .Include(x => x.Images)
            .FirstOrDefaultAsync(x => x.CategoryId == categoryId);
    }

    public async Task<Product?> GetProductBySellerIdAsync(Guid sellerId)
    {
        return await dbSet
            .AsNoTracking()
            .Include(x => x.Category)
            .Include(x => x.Seller)
            .Include(x => x.Images)
            .FirstOrDefaultAsync(x => x.SellerId == sellerId);
    }
}