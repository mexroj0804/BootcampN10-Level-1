using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N36_HT1.RecordModels
{
    internal record Manager(Guid PersonId, string FirstName, string LastName, string Department, decimal Salary, List<Employee> Employees) 
        : Employee(PersonId, FirstName, LastName, Department, Salary);
}
