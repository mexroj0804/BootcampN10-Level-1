using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N27_HT1.Models
{
    internal class User
    {
        public Guid Id { get; set; }
        public string EmailAdress { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public User(string emailAdress, string password, bool isAdmin = false)
        {
            Id = Guid.NewGuid();
            EmailAdress = emailAdress;
            Password = password;
            IsAdmin = isAdmin;
        }
    }
}
