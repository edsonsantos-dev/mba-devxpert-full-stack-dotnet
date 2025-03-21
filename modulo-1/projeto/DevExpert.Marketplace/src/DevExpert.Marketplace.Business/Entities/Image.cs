using DevExpert.Marketplace.Business.Entities.AuditableEntities;

namespace DevExpert.Marketplace.Business.Entities;

public class Image : AddableEntity
{
    public int DisplayPosition { get; set; }
    public Guid ProductId { get; set; }
    
    public Product Product { get; set; }
}