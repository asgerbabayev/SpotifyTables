using Core.Entities.Base;
using Core.Entities.Identity;

namespace Core.Entities;

public class Playlist : BaseAuditable
{
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public AppUser AppUser { get; set; } = null!;
    public ICollection<Song> Songs { get; set; }
    public Playlist() => Songs = new HashSet<Song>();
}
