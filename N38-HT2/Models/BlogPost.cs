using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N38_HT2.Models
{
    internal class BlogPost
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateOnly CreatedAt { get; set; }
        public DateOnly UpdatedAt { get; set; }
        public int ReadTime { get; set; }
        //public BlogPost(int id, string title, string content, DateTime createdAt, DateTime updatedAt, int readTime)
        //{
        //    Id = Guid.NewGuid();
        //    Title = title;
        //    Content = content;
        //    CreatedAt = createdAt;
        //    UpdatedAt = updatedAt;
        //    ReadTime = readTime;
        //}
    }
}
