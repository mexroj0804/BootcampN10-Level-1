using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using N24_HT1.Interfaces;
using N24_HT1.Models;

namespace N24_HT1.Services
{
    internal class UserService : IUserService
    {
        List<User> users = new List<User>();
        public User Add(string firstname, string lastname, string emailadress)
        {
            if (EmailAdressValid(emailadress))
            {
                var result = new User(firstname, lastname, emailadress);
                users.Add(result);
                return result;
            }
            else
            {
                throw new Exception("Invalid EmailAdress!");
            }
        }

        public void Delete(Guid id)
        {
            var deleted = users.FirstOrDefault(item => item.Id == id);
            if (deleted != null)
            {
                deleted.IsDeleted = true;
            }
            else
            {
                throw new Exception("Bunday ID mavjud emas!");
            }
        }

        public List<User> Filter(UserFilterModel userfiltermodel)
        {
            var filterUser = users.Where(item => item.FirstName == userfiltermodel.FirstName
            && item.LastName == userfiltermodel.LastName).ToList();
            var result = filterUser.Skip((userfiltermodel.PageToken - 1) * userfiltermodel.PageSize)
                .Take(userfiltermodel.PageSize).ToList();
            return result;
        }

        public List<User> Get(int pagesize, int pagetoken)
        {
            var response = users.Skip((pagetoken - 1) * pagesize).Take(pagesize).ToList();
            return response;

        }

        public List<User> Search(string searchKeywoard, int pagesize, int pagetoken)
        {
            var searchingUsers = users.Where(user => user.FirstName.ToLower().Contains(searchKeywoard.ToLower())
            || user.LastName.ToLower().Contains(searchKeywoard.ToLower())
            || user.EmailAdress.ToLower().Contains(searchKeywoard.ToLower())).ToList();
            var result = searchingUsers.Skip((pagetoken - 1) * pagesize).Take(pagesize).ToList();
            return result;
        }

        public List<User> Update(User user)
        {
            var update = users.FirstOrDefault(item => item.FirstName == user.FirstName && item.LastName == user.LastName);
            update.EmailAdress = user.EmailAdress;
            update.IsDeleted = user.IsDeleted;
            return users;
        }

        public bool EmailAdressValid(string emailadress)
        {
            if (Regex.IsMatch(emailadress, @"^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+$") == true)
                return true;
            else
                return false;
        }
    }
}
