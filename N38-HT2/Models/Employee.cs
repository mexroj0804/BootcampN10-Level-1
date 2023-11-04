using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N38_HT2.Models
{
    internal class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string EmailAddress { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public override string ToString()
        {
            return $"Id: {Id}";
        }

    }
}
