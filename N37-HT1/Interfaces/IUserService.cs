﻿using N37_HT1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N37_HT1.Interfaces
{
    internal interface IUserService
    {
        public IEnumerable<User> GetUsers();
    }
}
