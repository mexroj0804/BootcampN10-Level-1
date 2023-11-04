using FileBaseContext.Abstractions.Models.Entity;

namespace N63_HT1.Models;

public class StorageFile : IFileSetEntity<Guid>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Path { get; set; }
    public Guid UserId { get; set; }
    public DateTime CreatedAt { get; set; }
}
