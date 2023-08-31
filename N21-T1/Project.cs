using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_T1
{
    internal class Project
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Task> Tasks = new List<Task>();

        public Project(string title, string discription, Task task)
        {
            Id = Guid.NewGuid();
            Title = title;
            Description = discription;
            Tasks.Add(task);
        }

        public void AddTask(Task task)
        {
            Tasks.Add(task);
        }
    }
}
