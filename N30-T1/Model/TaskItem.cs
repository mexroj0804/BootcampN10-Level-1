using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N30_T1.Model
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public TaskItem(int id, string description, bool iscompleted = false)
        {
            Id = id;
            Description = description;
            IsCompleted = iscompleted;
        }
    }
}
