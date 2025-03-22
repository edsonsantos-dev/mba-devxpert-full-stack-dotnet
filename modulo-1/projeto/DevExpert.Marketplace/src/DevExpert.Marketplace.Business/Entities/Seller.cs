using DevExpert.Marketplace.Business.Entities.AuditableEntities;
using DevExpert.Marketplace.Business.Interfaces;
using DevExpert.Marketplace.Shared.Extensions;

namespace DevExpert.Marketplace.Business.Entities;

public class Seller : ModifiableEntity
{
    public string? FullName { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    
    public Seller() { }

    public Seller(
        string? fullName,
        string? email, 
        string? phoneNumber,
        INotifier notifier)
    {
        FullName = fullName;
        Email = email;
        PhoneNumber = phoneNumber;
        
        Validation(notifier);
    }
    
    public sealed override void Validation(INotifier notifier)
    {
        if (FullName.IsNullOrEmpty())
            notifier.AddNotification(new($"Full name is required."));

        if (Email.IsNullOrEmpty())
            notifier.AddNotification(new($"Email is required."));
    }
}