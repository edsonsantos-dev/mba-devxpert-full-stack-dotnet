using DevExpert.Marketplace.Core.Entities;
using DevExpert.Marketplace.Core.Interfaces.Repositories;
using DevExpert.Marketplace.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DevExpert.Marketplace.Data.Repositories;

public class CategoryRepository(MarketplaceContext context, DbSet<Category> dbSet)
    : Repository<Category>(context, dbSet), ICategoryRepository
{
    public async Task<Category?> GetCategoryWithProductsAsync(Guid id)
    {
        return await DbSet
            .AsNoTracking()
            .Include(c => c.Products)
            .FirstOrDefaultAsync(c => c.Id == id);
    }
}