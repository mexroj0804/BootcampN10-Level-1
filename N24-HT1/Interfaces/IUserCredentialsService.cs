using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N24_HT1.Models;

namespace N24_HT1.Interfaces
{
    internal interface IUserCredentialsService
    {
        public UserCredentials Add(string password, Guid userId);

        public UserCredentials GetByUserId(Guid userId);
    }
}
