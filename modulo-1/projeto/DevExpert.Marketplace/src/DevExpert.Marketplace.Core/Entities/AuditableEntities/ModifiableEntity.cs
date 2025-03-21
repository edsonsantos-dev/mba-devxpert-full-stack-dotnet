namespace DevExpert.Marketplace.Core.Entities.AuditableEntities;

public abstract class ModifiableEntity : AddableEntity
{
    public DateTime? ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }
}