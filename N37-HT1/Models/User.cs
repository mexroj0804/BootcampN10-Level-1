﻿using N37_HT1.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N37_HT1.Models
{
    internal class User
    {
        private Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public Status Status { get; set; }
        public User(string firstName, string lastName, string emailAddress, Status status)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Status = status;
            EmailAddress = emailAddress;
        }
    }
}
