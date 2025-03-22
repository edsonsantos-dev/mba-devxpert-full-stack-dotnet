using DevExpert.Marketplace.Core.Interfaces;

namespace DevExpert.Marketplace.Core.Entities.AuditableEntities;

public abstract class Entity
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public virtual void Validation(INotifier notifier) { }
}