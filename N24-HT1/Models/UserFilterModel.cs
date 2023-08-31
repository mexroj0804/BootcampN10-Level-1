using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N24_HT1.Models
{
    public class UserFilterModel : FilterModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public UserFilterModel(int pagesize, int pagetoken, string? firstname, string? lastname)
        {
            PageSize = pagesize;
            PageToken = pagetoken;
            FirstName = firstname;
            LastName = lastname;
        }
    }
}
