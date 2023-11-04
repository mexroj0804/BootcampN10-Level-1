using N53_HT1.Common;

namespace N53_HT1.Models
{
    public class User : IEntitiy
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public User(Guid id, string firstName, string lastName, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = email;
        }
    }
}
