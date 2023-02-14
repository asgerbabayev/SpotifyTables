using Core.Entities.Base;

namespace Core.Entities;

public class Song : BaseAuditable
{
    public string Name { get; set; } = null!;
    public DateTime ReleaseDate { get; set; }
    public Artist Artist { get; set; } = null!;
    public Album Album { get; set; } = null!;
    public ICollection<Playlist> Playlists { get; set; }
    public Song() => Playlists = new HashSet<Playlist>();

}
