using DevExpert.Marketplace.Business.Entities;
using DevExpert.Marketplace.Business.Interfaces;
using DevExpert.Marketplace.Business.Interfaces.Repositories;

namespace DevExpert.Marketplace.Business.Services;

public class CategoryService(ICategoryRepository repository, INotifier notifier)
    : Service<Category>(repository, notifier);