namespace DevExpert.Marketplace.Core.Entities.AuditableEntities;

public abstract class AddableEntity : Entity
{
    public DateTime AddedOn { get; set; }
    public Guid AddedBy { get; set; }
}