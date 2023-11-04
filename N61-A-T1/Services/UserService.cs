using Mapster;
using N61_A_T1.DTOs;
using N61_A_T1.Entities;

namespace N61_A_T1.Services
{
    public class UserService
    {
        private IList<User> _users = new List<User>();

        public User Creste(UserForCreation userForCreation)
        {
            var existUser = _users.FirstOrDefault(u => u.Email == userForCreation.Email);

            if (existUser != null)
            {
                Console.WriteLine("Bu user mavjud!");
                return existUser;
            }

            var newUser = userForCreation.Adapt<User>();
            
            newUser.Id = Guid.NewGuid();
            newUser.CreatedAt = DateTime.UtcNow;
            newUser.UpdatedAt = DateTime.UtcNow;

            _users.Add(newUser);
            
            return newUser;
        }

        public List<UserViewModel> GetUsers()
        {
            return _users.Adapt<List<UserViewModel>>();
        }
    }
}