using Core.Entities.Base;

namespace Core.Entities;

public class Artist : BaseAuditable
{
    public Artist()
    => (Songs) = (new HashSet<Song>());

    public string FullName { get; set; } = null!;
    public DateTime BirthDate { get; set; }
    public ICollection<Song> Songs { get; set; }
}
