using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N24_HT1.Services
{
    internal class RegistrationService
    {
        public UserService userServices;
        public UserCredentialsService userCredentialsServices;

        public RegistrationService(UserService userService, UserCredentialsService userCredentialsService)
        {
            userServices = userService;
            userCredentialsServices = userCredentialsService;
        }


        public bool Register(string firstName, string lastName, string emailAddress, string password)
        {
            try
            {
                var result = userServices.Add(firstName, lastName, emailAddress);
                userCredentialsServices.Add(password, result.Id);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
