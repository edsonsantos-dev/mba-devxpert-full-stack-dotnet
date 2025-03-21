using DevExpert.Marketplace.Business.Interfaces;

namespace DevExpert.Marketplace.Business.Entities.AuditableEntities;

public abstract class Entity
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public virtual void Validation(INotifier notifier) { }
}