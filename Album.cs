using Core.Entities.Base;

namespace Core.Entities;

public class Album : BaseAuditable
{
    public string Name { get; set; } = null!;
    public DateTime ReleaseDate { get; set; }
    public ICollection<Song> Songs { get; set; }
    public Album() => Songs = new HashSet<Song>();
}
