using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N32_T2.Models
{
    public abstract class AuditableEntity
    {
        public abstract string createDate { get; set; }
        public abstract string modifiedDate {  get; set; }
    }
}
