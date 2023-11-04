using FileBaseContext.Abstractions.Models.Entity;

namespace N52_HT1.Models
{
    public class User : IFileSetEntity<Guid>
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }
}
