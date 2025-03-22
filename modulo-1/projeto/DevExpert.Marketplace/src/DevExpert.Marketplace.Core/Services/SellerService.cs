using DevExpert.Marketplace.Core.Entities;
using DevExpert.Marketplace.Core.Interfaces;
using DevExpert.Marketplace.Core.Interfaces.Repositories;

namespace DevExpert.Marketplace.Core.Services;

public class SellerService(ISellerRepository repository, INotifier notifier)
    : Service<Seller>(repository, notifier)
{
    public override Task<bool> RemoveAsync(Guid id)
    {
        notifier.AddNotification(new("Seller can't be deleted."));
        return Task.FromResult(false);
    }
}