using N29_Practise.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace N29_Practise.Service
{
    public class HumanResourceManager : IHumanResourceManager
    {
        public void AddDepartment(Department department)
        {
            var fileName = $"{department.Name.ToLower()}.json";
            var folderName = Path.Combine(Directory.GetCurrentDirectory(), "Storage");
            var filePath = Path.Combine(folderName, fileName);
            if (!File.Exists(filePath))
                return;

            // file ichidagi ma'lutmolarni json shaklida o'qib, listga o'girib  va posts ga o'zlashtirish
            var fileStream = File.Open(filePath, FileMode.Open);
            var previousData = JsonSerializer.Deserialize<List<Department>>(fileStream);

            //Clear();
            //AddRange(previousData);

            fileStream.Flush();
            fileStream.Close();
        }

        public void AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void EditDepartments(Department department)
        {
            throw new NotImplementedException();
        }

        public void EditEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Department FindDepartment(string name)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetDepartments()
        {
            throw new NotImplementedException();
        }

        public void RemoveEmployee(int id)
        {
            throw new NotImplementedException();
        }
    }
}
