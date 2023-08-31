using N29_Practise.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N29_Practise.Service
{
    public interface IHumanResourceManager
    {
        void AddDepartment(Department department);
        List<Department> GetDepartments();
        void EditDepartments(Department department);
        void AddEmployee(Employee employee);
        void RemoveEmployee(int id);
        void EditEmployee(Employee employee);
        Department FindDepartment(string name);
    }
}
