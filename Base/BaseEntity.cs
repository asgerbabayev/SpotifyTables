namespace Core.Entities.Base;

public abstract class BaseEntity<TKey> where TKey : IEquatable<TKey>
{
    public TKey Id { get; set; } = default!;
}
public abstract class BaseEntity : BaseEntity<int> { }