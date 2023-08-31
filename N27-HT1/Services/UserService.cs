using N27_HT1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N27_HT1.Services
{
    internal class UserService
    {
        List<User> users = new()
        {
            new User("g'ishmat@gmail.com", "g'ishmat007"),
            new User("toshmateshmatov@email.com", "toshmatboy", true),
            new User("mexrojxaybullayev08@gmail.com", "Mexrojiddin008")
        };
        public void Add(string emailAdress, string password)
        {
            users.Add(new(emailAdress, password));
        }

        public List<User> GetUsers()
        {
            return users;
        }
    }
}
