using DevExpert.Marketplace.Business.Entities;
using DevExpert.Marketplace.Business.Interfaces;
using DevExpert.Marketplace.Business.Interfaces.Repositories;

namespace DevExpert.Marketplace.Business.Services;

public class SellerService(ISellerRepository repository, INotifier notifier)
    : Service<Seller>(repository, notifier)
{
    public override Task<bool> RemoveAsync(Guid id)
    {
        notifier.AddNotification(new("Seller can't be deleted."));
        return Task.FromResult(false);
    }
}