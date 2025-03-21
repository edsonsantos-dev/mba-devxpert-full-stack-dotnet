using DevExpert.Marketplace.Business.Entities.AuditableEntities;
using DevExpert.Marketplace.Business.Interfaces;
using DevExpert.Marketplace.Shared.Extensions;

namespace DevExpert.Marketplace.Business.Entities;

public class Product : ModifiableEntity
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    
    public List<Image> Images { get; set; } = [];
    public Guid CategoryId { get; set; }
    public Category? Category { get; set; }
    public Guid SellerId { get; set; }
    public Seller? Seller { get; set; }

    public Product(
        string? name,
        string? description,
        decimal price,
        int stock,
        Guid categoryId,
        Guid sellerId,
        List<Image> images,
        INotifier notifier)
    {
        Name = name;
        Description = description;
        Price = price;
        Stock = stock;
        CategoryId = categoryId;
        SellerId = sellerId;
        Images.AddRange(images);

        Validation(notifier);
    }

    public bool UpdateStock(int stock, INotifier notifier)
    {
        if (Stock <= 0)
        {
            notifier.AddNotification(new($"Stock must be greater than 0."));
            return false;
        }

        Stock = stock;

        return true;
    }

    public bool UpdatePrice(decimal price, INotifier notifier)
    {
        if (Price <= 0)
        {
            notifier.AddNotification(new($"Price must be greater than 0."));
            return false;
        }

        Price = price;

        return true;
    }

    public sealed override void Validation(INotifier notifier)
    {
        if (Name.IsNullOrEmpty())
            notifier.AddNotification(new($"Name is required."));

        if (Description.IsNullOrEmpty())
            notifier.AddNotification(new($"Description is required."));

        if (Stock <= 0)
            notifier.AddNotification(new($"Stock must be greater than 0."));

        if (Price <= 0)
            notifier.AddNotification(new($"Price must be greater than 0."));

        if (CategoryId == Guid.Empty)
            notifier.AddNotification(new($"Category is required."));

        if (SellerId == Guid.Empty)
            notifier.AddNotification(new($"Seller is required."));

        if (Images.IsNullOrEmpty())
            notifier.AddNotification(new($"Images is required."));
    }
}