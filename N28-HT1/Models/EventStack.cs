using N28_HT1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N28_HT1.Models
{
    internal class EventStack<T> where T : IEvent
    {
        List<T> events = new();

        public EventStack()
        {
            events = new List<T>();
        }

        public void Push(T item)
        {
            if (events.All(x => x.Date < item.Date))
            {
                events.Add(item);
                return;
            }

            throw new Exception("Event date is not valid");
        }

        public T Peek()
        {
            if (events.Count == 0) throw new Exception("Stack is empty");

            return events.Last();
        }

        public T Pop()
        {
            if (events.Count == 0) throw new Exception("Stack is empty");

            var eventB = events.Last();
            events.Remove(eventB);
            return eventB;
        }
    }
}
