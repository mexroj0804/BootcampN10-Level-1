using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N29_Practise.Model
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int WorkerLimit { get; set; }
        public decimal SalaryLimit { get; set; }
        List<Employee> Employees { get; set; }
        public Department()
        {
            
        }

        public void CalcSalaryAvr()
        {

        }
    }
}
