using FileBaseContext.Abstractions.Models.Entity;

namespace N62_A_T1.DTOs
{
    public class UserViewModel : IFileSetEntity<Guid>
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
