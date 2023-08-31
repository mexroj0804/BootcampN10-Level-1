using N34_AT1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace N34_AT1.Services
{
    internal class FileSaveService<T> where T : class
    {
        public void Save(List<T> person)
        {
            var filePath = Path.Combine(Path.GetTempPath());
            var json = JsonSerializer.Serialize(person);
            File.AppendAllText(filePath, json);
        }

    }
}
