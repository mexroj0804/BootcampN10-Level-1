using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N23_HT2.Models
{
    internal class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAdress { get; set; }
        public User(string firstName, string lastName, string emailAdress)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAdress = emailAdress;
        }
    }
}
