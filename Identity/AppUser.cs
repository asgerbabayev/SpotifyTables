using Microsoft.AspNetCore.Identity;

namespace Core.Entities.Identity;

public class AppUser : IdentityUser<int>
{
    public string Name { get; set; } = null!;
    public string Surname { get; set; } = null!;
    public ICollection<Playlist> Playlists { get; set; }
    public ICollection<Wishlist> Wishlists { get; set; }

    public AppUser() => (Playlists, Wishlists) = (new HashSet<Playlist>(), new HashSet<Wishlist>());
}
