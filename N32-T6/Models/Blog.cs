using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N32_T6.Models
{
    internal class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public Blog(int id, string title, string body)
        {
            Id = id;
            Title = title;
            Body = body;
        }
    }
}
