using N36_HT2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N36_HT2.Services
{
    internal class UserService
    {
        List<User> users = new();

        public void Add(User user)
        {
            users.Add(user);
        }
        public void Remove(int id)
        {
            var result = users.FirstOrDefault(item => item.Id == id);
            if (result != null) users.Remove(result);
            else Console.WriteLine("This Id is not found!");
        }

        public void Update(int id, string firstName, string lastName)
        {
            var result = users.Find(item => item.Id == id);
            if (result != null)
            {
                result.FirstName = firstName;
                result.LastName = lastName;
            }
            else Console.WriteLine("This Id is not found!");
        }

        public List<User> Get()
        {
            return users;
        }
    }
}
