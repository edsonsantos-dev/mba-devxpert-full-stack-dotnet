using DevExpert.Marketplace.Business.Entities;
using DevExpert.Marketplace.Business.Interfaces.Repositories;
using DevExpert.Marketplace.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DevExpert.Marketplace.Data.Repositories;

public class ProductRepository(MarketplaceContext context, DbSet<Product> dbSet)
    : Repository<Product>(context, dbSet), IProductRepository;