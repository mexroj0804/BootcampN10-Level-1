using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N33_T1.Services
{
    internal class JsonFileManagementService : FileManagementServiceBase
    {
        public override Task<string> ReadAsync(string path)
        {
            if (path.Split('.').Last() != "json")
                throw new NotImplementedException();
            return File.ReadAllTextAsync(path);
        }

        public override Task WriteAsync(string path, string data)
        {
            throw new NotImplementedException();
        }
    }
}
