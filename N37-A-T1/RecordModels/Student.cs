using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N37_A_T1.RecordModels
{
    public record Student(string FirsName, string LastName, int Course) 
        : Person(FirsName, LastName);
}
