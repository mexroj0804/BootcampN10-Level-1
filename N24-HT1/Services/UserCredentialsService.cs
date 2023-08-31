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
    internal class UserCredentialsService : IUserCredentialsService
    {
        List<UserCredentials> _userCredintials = new();
        public UserCredentials Add(string password, Guid userId)
        {
            if (Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*[0-9])(?=.*[^a-zA-Z0-9]).{8,}$"))
            {
                var result = new UserCredentials(password, userId);
                _userCredintials.Add(result);
                return result;
            }
            else throw new Exception("Password is invalid!");

        }

        public UserCredentials GetByUserId(Guid userId)
        {
            var result = _userCredintials.FirstOrDefault(user => user.UserId == userId);
            return result;
        }
    }
}
