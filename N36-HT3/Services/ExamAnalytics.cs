using N36_HT2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N36_HT2.Services
{
    internal class ExamAnalytics
    {
        private ExamScoreService _examScoreService;
        private UserService _userService;
        public ExamAnalytics(ExamScoreService examScore, UserService userService)
        {
            _examScoreService = examScore;
            _userService = userService;
        }
        public IEnumerable<(string FullName, int Score)> GetScore()
        {
            return _userService.Get().Select(user =>
            {
                var FullName = $"{user.FirstName} {user.LastName}";
                var score = _examScoreService.Get(user.Id).Score;
                return(FullName, score);
            });
        }
    }
}
