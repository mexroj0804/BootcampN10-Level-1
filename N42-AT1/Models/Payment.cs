using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N42_AT1.Models
{
    internal class Payment
    {
        public long Id { get; set; }
        public long StudentId { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Payment(long id, long studentId, decimal amount)
        {
            Id = id;
            StudentId = studentId;
            Amount = amount;
            CreatedAt = DateTime.Now;
        }
    }
}
