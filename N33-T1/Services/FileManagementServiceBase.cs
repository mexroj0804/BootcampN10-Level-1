using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N33_T1.Services
{
    public abstract class FileManagementServiceBase
    {
        public abstract Task<string> ReadAsync(string path);
        public abstract Task WriteAsync(string path, string data);


    }
}
