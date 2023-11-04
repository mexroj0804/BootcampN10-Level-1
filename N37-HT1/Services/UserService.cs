using N37_HT1.Interfaces;
using N37_HT1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N37_HT1.Services
{
    internal class UserService : IUserService
    {
        List<User> users = new();
        public IEnumerable<User> GetUsers()
        {
            foreach (var user in users)
            {
                yield return user;
            }
        }
    }
}
