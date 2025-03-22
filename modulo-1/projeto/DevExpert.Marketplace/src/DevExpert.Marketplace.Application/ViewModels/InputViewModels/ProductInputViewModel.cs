using DevExpert.Marketplace.Core.Entities;
using DevExpert.Marketplace.Core.Interfaces;
using Microsoft.AspNetCore.Http;

namespace DevExpert.Marketplace.Application.ViewModels.InputViewModels;

public class ProductInputViewModel(INotifier notifier) : InputViewModelBase<Product>(notifier)
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }

    public List<Image> Images { get; set; }
    public Guid CategoryId { get; set; }
    public Guid SellerId { get; set; }

    public override Product ToModel()
    {
        return new Product(Name, Description, Price, Stock, CategoryId, SellerId, Images, notifier);
    }
}