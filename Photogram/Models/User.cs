using FileBaseContext.Abstractions.Models.Entity;

namespace Photogram.Models
{
    public class User : IFileSetEntity<Guid>
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string ProfileImagePath { get; set; }
        public bool IsDeleted { get; internal set; }
    }
}
