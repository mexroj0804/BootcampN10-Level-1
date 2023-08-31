using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_T1
{
    internal class Developer
    {
        public Guid Id { get; set; }
        public string Userame { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public string EmailAdress { get; set; }

        public List<Project> AssignedProjects = new List<Project>();
        public List<string> Comments = new List<string>();

        public Developer(string username, string password, int roleid, string email)
        {
            Id = Guid.NewGuid();
            Userame = username;
            Password = password;
            RoleId = roleid;
            EmailAdress = email;
        }
    }
}
