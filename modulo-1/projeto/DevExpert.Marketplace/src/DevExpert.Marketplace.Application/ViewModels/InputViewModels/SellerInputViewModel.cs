using DevExpert.Marketplace.Core.Entities;
using DevExpert.Marketplace.Core.Interfaces;

namespace DevExpert.Marketplace.Application.ViewModels.InputViewModels;

public class SellerInputViewModel(INotifier notifier) : InputViewModelBase<Seller>(notifier)
{
    public string? FullName { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }

    public override Seller ToModel()
    {
        return new Seller(FullName, Email, PhoneNumber, notifier);
    }
}