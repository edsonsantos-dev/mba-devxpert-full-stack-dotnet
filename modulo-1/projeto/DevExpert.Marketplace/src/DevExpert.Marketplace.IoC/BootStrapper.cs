using DevExpert.Marketplace.Core.Entities;
using DevExpert.Marketplace.Core.Interfaces.Repositories;
using DevExpert.Marketplace.Core.Interfaces.Services;
using DevExpert.Marketplace.Core.Services;
using DevExpert.Marketplace.Data.Context;
using DevExpert.Marketplace.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DevExpert.Marketplace.IoC;

public static class BootStrapper
{
    public static void RegisterIoC(this IServiceCollection services)
    {
        services.AddScoped<DbContext, MarketplaceContext>();

        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IImageRepository, ImageRepository>();
        services.AddScoped<ISellerRepository, SellerRepository>();

        services.AddScoped<IService<Category>, CategoryService>();
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IService<Seller>, SellerService>();
    }
}