using DevExpert.Marketplace.Business.Entities.AuditableEntities;
using DevExpert.Marketplace.Business.Interfaces;

namespace DevExpert.Marketplace.Business.Entities;

public class Image : AddableEntity
{
    public int DisplayPosition { get; set; }
    public bool IsCover => DisplayPosition == 1;

    public Guid ProductId { get; set; }
    public Product Product { get; set; }

    public Image() { }

    public Image(
        int displayPosition,
        Guid productId,
        INotifier notifier)
    {
        DisplayPosition = displayPosition;
        ProductId = productId;
        
        Validation(notifier);
    }

    public sealed override void Validation(INotifier notifier)
    {
        if (ProductId == Guid.Empty)
            notifier.AddNotification(new($"Product is required."));
    }
}