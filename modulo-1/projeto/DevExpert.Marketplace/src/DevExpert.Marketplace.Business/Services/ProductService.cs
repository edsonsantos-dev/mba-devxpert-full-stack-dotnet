using DevExpert.Marketplace.Business.Entities;
using DevExpert.Marketplace.Business.Interfaces;
using DevExpert.Marketplace.Business.Interfaces.Repositories;

namespace DevExpert.Marketplace.Business.Services;

public class ProductService(IProductRepository repository, INotifier notifier) 
    : Service<Product>(repository, notifier);