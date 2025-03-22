using DevExpert.Marketplace.Core.Entities;
using DevExpert.Marketplace.Core.Interfaces.Repositories;
using DevExpert.Marketplace.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DevExpert.Marketplace.Data.Repositories;

public class ImageRepository(MarketplaceContext context, DbSet<Image> dbSet)
    : Repository<Image>(context, dbSet), IImageRepository;