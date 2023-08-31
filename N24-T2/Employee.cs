using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N24_T2
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public int KPI { get; set; }
        public Employee(string fName, string lName, double salary, int kpi)
        {
            FirstName = fName;
            LastName = lName;
            Salary = salary;
            KPI = kpi;
        }
    }
}
