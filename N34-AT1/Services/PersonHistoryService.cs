using N34_AT1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N34_AT1.Services
{
    internal class PersonHistoryService
    {
        List<PersonHistory> personsHistory = new();
        FileSaveService<PersonHistory> fileSaver = new FileSaveService<PersonHistory>();

        public void Add(Person person)
        {
            personsHistory.Add(new PersonHistory(person, "Person is added"));
            fileSaver.Save(personsHistory);
        }
        public void Remove(Person person)
        {
            personsHistory.Add(new PersonHistory(person, "Person is deleted"));
            fileSaver.Save(personsHistory);
        }

        public void Update(Person person)
        {
            personsHistory.Add(new PersonHistory(person, "Person is updated"));
            fileSaver.Save(personsHistory);
        }
    }
}
