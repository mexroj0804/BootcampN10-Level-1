using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N38_HT1.Models
{
    internal class UsersContainer : IEnumerable<User>
    {
        private IEnumerable<User> _users;
        public UsersContainer(IEnumerable<User> users)
        {
            _users = users;
        }
        public UsersContainer()
        {
            _users = new List<User>();
        }

        public User this[Guid id] => _users.First(user => user.Id == id);
        public User this[string keywoard] => _users.First(user => user.FirstName.ToLower().Contains(keywoard.ToLower())
                                                || user.LastName.ToLower().Contains(keywoard.ToLower()) 
                                                || user.EmailAddress.ToLower().Contains(keywoard.ToLower()));
        public User this[int index] => _users.ToArray()[index];
        public IEnumerator<User> GetEnumerator()
        {
            return _users.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _users.GetEnumerator();
        }
    }
}
