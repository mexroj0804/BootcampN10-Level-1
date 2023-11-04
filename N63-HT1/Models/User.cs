using FileBaseContext.Abstractions.Models.Entity;

namespace N63_HT1.Models;

public class User : IFileSetEntity<Guid>
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string EmailAddress { get; set; } = default!;
    public string Password { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public DateTime CreatedAt { get; set; }
}
