using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N6_T1
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDay { get; set; }
        public decimal Payment { get ; set; }
        public string EduType { get; set; }
        public decimal PaymentAmount { get; set; }

        public int GetAge() => DateTime.Now.Year - BirthDay.Year;

        public string GetShortName() => FullName.PadRight(45,' ');

        public string GetAmount()
        {
            decimal amount = Payment - PaymentAmount;
            if (amount < 0) return $"{amount} haqdor";
            else return $"{amount} qarzdor";
        }
    }
}
