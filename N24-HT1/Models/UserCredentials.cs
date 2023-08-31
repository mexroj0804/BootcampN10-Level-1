using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N24_HT1.Models
{
    public class UserCredentials
    {
        public Guid Id { get; set; }
        public string Password { get; set; }
        public Guid UserId { get; set; }

        public UserCredentials(string password, Guid userid)
        {
            Id = Guid.NewGuid();
            Password = password;
            UserId = userid;
        }
    }
}
