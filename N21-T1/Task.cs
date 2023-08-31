using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_T1
{
    internal class Task
    {
        public Guid Id {  get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsCompleted { get; set; }

        public List<string> Comments = new List<string>();

        public Task(string title, string description, DateTime deadline, bool iscompleted, string comment)
        {
            Id = Guid.NewGuid();
            Title = title;
            Description = description;
            Deadline = deadline;
            IsCompleted = iscompleted;
            Comments.Add(comment);
        }
    }
}
