namespace Core.Entities.Base;

public class BaseAuditable : BaseEntity
{
    public string CreatedBy { get; set; } = null!;
    public DateTime CreatedDate { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime? UpdatedDate { get; set; }
}
