using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N38_HT2.Models
{
    internal class UserAddress
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int PostalCode { get; set; }

        public UserAddress(int id, string fullName, string country, string city, string street, int postalCode)
        {
            Id = id;
            FullName = fullName;
            Country = country;
            City = city;
            Street = street;
            PostalCode = postalCode;
        }

    }
}
