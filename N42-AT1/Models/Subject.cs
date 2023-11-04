using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N42_AT1.Models
{
    internal class Subject
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Subject(long id, string name)
        {
            Id = id;
            Name = name;
            CreatedAt = DateTime.Now;
        }
    }
}
