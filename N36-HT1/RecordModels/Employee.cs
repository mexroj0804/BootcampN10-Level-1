using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N36_HT1.RecordModels
{
    internal record Employee(Guid PersonId,string FirstName, string LastName, string Department, decimal Salary) 
        : Person(PersonId, FirstName, LastName);
}
