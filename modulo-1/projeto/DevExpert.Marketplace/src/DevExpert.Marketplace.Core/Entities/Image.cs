using DevExpert.Marketplace.Core.Interfaces;
using DevExpert.Marketplace.Core.Entities.AuditableEntities;
using DevExpert.Marketplace.Shared.Extensions;
using Microsoft.AspNetCore.Http;

namespace DevExpert.Marketplace.Core.Entities;

public class Image : AddableEntity
{
    public int DisplayPosition { get; set; }
    public string? Path { get; set; }
    public bool IsCover => DisplayPosition == 1;

    public Guid ProductId { get; set; }
    public Product Product { get; set; }

    public Image() { }

    public Image(
        int displayPosition,
        string? path,
        Guid productId,
        INotifier notifier)
    {
        DisplayPosition = displayPosition;
        Path = path;
        ProductId = productId;
        
        Validation(notifier);
    }

    public sealed override void Validation(INotifier notifier)
    {
        if (ProductId == Guid.Empty)
            notifier.AddNotification(new($"Product is required."));
        
        if (Path.IsNullOrEmpty())
            notifier.AddNotification(new($"Path is required."));
    }

    public async Task SaveAsync(IFormFile file)
    {
        using var stream = new FileStream(Path!, FileMode.Create);
        await file.CopyToAsync(stream);
    }
}