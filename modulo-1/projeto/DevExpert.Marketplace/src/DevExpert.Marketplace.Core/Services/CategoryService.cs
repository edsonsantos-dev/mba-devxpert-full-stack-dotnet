using DevExpert.Marketplace.Core.Entities;
using DevExpert.Marketplace.Core.Interfaces;
using DevExpert.Marketplace.Core.Interfaces.Repositories;

namespace DevExpert.Marketplace.Core.Services;

public class CategoryService(ICategoryRepository repository, INotifier notifier)
    : Service<Category>(repository, notifier)
{
    public async override Task<bool> RemoveAsync(Guid id)
    {
        var category = await repository.GetCategoryWithProductsAsync(id);

        if (category == null)
        {
            notifier.AddNotification(new("Category not found."));
            return false;
        }

        if (category.CanBeDeleted(notifier))
            return await repository.RemoveAsync(id);

        return false;
    }
}