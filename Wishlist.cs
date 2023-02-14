using Core.Entities.Base;
using Core.Entities.Identity;

namespace Core.Entities;

public class Wishlist : BaseAuditable
{
    public ICollection<Song> Songs { get; set; }
    public ICollection<AppUser> AppUsers { get; set; }
    public Wishlist() => (Songs, AppUsers) = (new HashSet<Song>(), new HashSet<AppUser>());
}