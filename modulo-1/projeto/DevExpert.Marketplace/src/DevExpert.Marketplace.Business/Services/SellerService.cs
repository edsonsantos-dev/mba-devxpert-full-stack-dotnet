using DevExpert.Marketplace.Business.Entities;
using DevExpert.Marketplace.Business.Interfaces;
using DevExpert.Marketplace.Business.Interfaces.Repositories;

namespace DevExpert.Marketplace.Business.Services;

public class SellerService(ISellerRepository repository, INotifier notifier) 
    : Service<Seller>(repository, notifier);