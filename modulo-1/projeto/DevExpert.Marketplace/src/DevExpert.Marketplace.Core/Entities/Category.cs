using DevExpert.Marketplace.Core.Interfaces;
using DevExpert.Marketplace.Core.Entities.AuditableEntities;
using DevExpert.Marketplace.Shared.Extensions;

namespace DevExpert.Marketplace.Core.Entities;

public class Category : ModifiableEntity
{
    public string? Name { get; set; }
    public string? Description { get; set; }

    public List<Product> Products { get; set; } = [];

    public Category() { }

    public Category(
        string? name,
        string? description,
        List<Product> products,
        INotifier notifier)
    {
        Name = name;
        Description = description;
        Products.AddRange(products);

        Validation(notifier);
    }

    public bool CanBeDeleted(INotifier notifier)
    {
        if (Products.IsNullOrEmpty())
            return true;

        notifier.AddNotification(new($"Category can not be deleted because it has products."));
        return false;
    }

    public sealed override void Validation(INotifier notifier)
    {
        if (Name.IsNullOrEmpty())
            notifier.AddNotification(new($"Name is required."));

        if (Description.IsNullOrEmpty())
            notifier.AddNotification(new($"Description is required."));
    }
}