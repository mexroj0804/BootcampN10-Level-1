using N36_HT2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N36_HT2.Services
{
    internal class ExamScoreService
    {
        List<ExamScore> scores = new();

        public void Add(ExamScore score)
        {
            scores.Add(score);
        }
        public void Remove(int userId)
        {
            var result = scores.FirstOrDefault(item => item.UserId == userId);
            if (result != null) scores.Remove(result);
            else Console.WriteLine("This Id is not found!");
        }

        public void Update(int userId, int score)
        {
            var result = scores.Find(item => item.UserId == userId);
            if (result != null) result.Score = score;
            else Console.WriteLine("This Id is not found!");
        }

        public ExamScore Get(int userId)
        {
            var result = scores.FirstOrDefault(item => item.UserId == userId);
            return result;
        }
    }
}
