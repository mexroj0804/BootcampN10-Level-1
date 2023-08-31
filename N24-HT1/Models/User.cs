using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N24_HT1.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAdress { get; set; }
        public bool IsDeleted { get; set; }

        public User(string firstname, string lastname, string emailadress, bool isdeleted = false)
        {
            Id = Guid.NewGuid();
            FirstName = firstname;
            LastName = lastname;
            EmailAdress = emailadress;
            IsDeleted = isdeleted;
        }
    }
}