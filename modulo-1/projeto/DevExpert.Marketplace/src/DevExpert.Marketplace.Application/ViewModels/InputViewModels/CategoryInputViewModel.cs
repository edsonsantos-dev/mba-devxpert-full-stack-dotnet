using DevExpert.Marketplace.Core.Entities;
using DevExpert.Marketplace.Core.Interfaces;

namespace DevExpert.Marketplace.Application.ViewModels.InputViewModels;

public class CategoryInputViewModel(INotifier notifier) : InputViewModelBase<Category>(notifier)
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public List<Product> Products { get; set; }

    public override Category ToModel()
    {
        return new Category(Name, Description, Products, notifier);
    }
}