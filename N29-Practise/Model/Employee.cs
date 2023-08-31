using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N29_Practise.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public string Fullname { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Position Position { get; set; }
        public decimal Salary { get; set; }
        public int DepartmentId { get; set; }

        //public static int _count = 1000;
        public string No { get; set; }

        //public Employee(int id, string firstname, string lastname, Position position, decimal salary, string departmentname, string no)
        //{
        //    Id = id;
        //    FirstName = firstname;
        //    LastName = lastname;
        //    Fullname = Firstname + " " + LastName;
        //    Position = position;
        //    Salary = salary;
        //    DepartmentName = departmentname;
        //    No = no;

        //}

        public Employee()
        {

        }


    }
}
