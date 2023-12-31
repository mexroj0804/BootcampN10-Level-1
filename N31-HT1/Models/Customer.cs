﻿using N31_HT1.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace N31_HT1.Models
{
    internal class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Country Country { get; set; }

        public Customer(int id, string firstName, string lastName, Country country)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Country = country;
        }
    }
}
