using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N36_HT2.Models
{
    internal class ExamScore
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public int Score { get; set; }

        public ExamScore(int userId, int id, int score)
        {
            UserId = userId;
            Id = id;
        }
    }
}
