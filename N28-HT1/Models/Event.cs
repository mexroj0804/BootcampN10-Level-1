using N28_HT1.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N28_HT1.Models
{
    internal class Event : IEvent
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public Event(string name, DateTime date)
        {
            Id = Guid.NewGuid();
            Name = name;
            Date = date;
        }
    }
}
