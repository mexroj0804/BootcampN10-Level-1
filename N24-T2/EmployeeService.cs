using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N24_T2
{
    public class EmployeeService
    {
        List<Employee> employees = new();
        public void GetBySalary(int pageSize, int pageToken)
        {
            var response = employees
                .OrderByDescending(item => item.Salary)
                .Skip(pageToken).ToList();
            response.ForEach(item => Console.WriteLine($"Fullname: {item.FirstName} " +
                $"{item.LastName}\tSalary: {item.Salary}\tKPI: {item.KPI}"));
        }
        public EmployeeService()
        {
            employees.Add(new Employee("Mexroj", "Xaybullayev", 200, 67));
            employees.Add(new Employee("Akbar", "Husanov", 249, 97));
            employees.Add(new Employee("Azizbek", "Hayitboyev", 190, 43));
            employees.Add(new Employee("Aziza", "Akbarova", 300, 55));
            employees.Add(new Employee("Ali", "Alimov", 189, 99));
            employees.Add(new Employee("Mexroj", "Xaybullayev", 200, 67));
            employees.Add(new Employee("Akbar", "Husanov", 249, 97));
            employees.Add(new Employee("Azizbek", "Hayitboyev", 190, 43));
            employees.Add(new Employee("Aziza", "Akbarova", 300, 55));
            employees.Add(new Employee("Ali", "Alimov", 189, 99));
        }
    }
}
