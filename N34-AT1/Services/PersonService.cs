using N34_AT1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N34_AT1.Services
{
    internal class PersonService
    {
        List<Person> persons = new();
        PersonHistoryService personHistory = new();
        public void Add(Person person)
        {
            persons.Add(person);
            personHistory.Add(person);
            
        }
        public void Remove(int id)
        {
            var result = persons.FirstOrDefault(item => item.Id == id);
            if (result != null)
            {
                persons.Remove(result);
                personHistory.Remove(result);
            }
            else Console.WriteLine("Id is not found!");
        }

        public void Update(Person person)
        {
            var result = persons.FirstOrDefault(item => item.Id == person.Id);
            if (result != null)
            {
                result.Name = person.Name;
                result.Surname = person.Surname;
                result.Age = person.Age;
                personHistory.Update(per);
            }
            else Console.WriteLine("Person is not found!");
        }
    }
}
