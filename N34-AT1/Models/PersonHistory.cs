using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N34_AT1.Models
{
    internal class PersonHistory
    {
        public int PersonId { get; set; }
        public string Activity { get; set; }

        public PersonHistory(Person person, string activity)
        {
            PersonId = person.Id;
            Activity = activity;
        }
    }
}
