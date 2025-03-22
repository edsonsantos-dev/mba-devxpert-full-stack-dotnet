using DevExpert.Marketplace.Business.Entities;
using DevExpert.Marketplace.Business.Interfaces.Repositories;
using DevExpert.Marketplace.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DevExpert.Marketplace.Data.Repositories;

public class CategoryRepository(MarketplaceContext context, DbSet<Category> dbSet)
    : Repository<Category>(context, dbSet), ICategoryRepository;