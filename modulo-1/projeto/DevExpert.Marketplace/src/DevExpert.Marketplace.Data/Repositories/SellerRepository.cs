using DevExpert.Marketplace.Core.Entities;
using DevExpert.Marketplace.Core.Interfaces.Repositories;
using DevExpert.Marketplace.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DevExpert.Marketplace.Data.Repositories;

public class SellerRepository(MarketplaceContext context, DbSet<Seller> dbSet) 
    : Repository<Seller>(context, dbSet), ISellerRepository;