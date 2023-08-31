using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N24_T3
{
    public class Movie
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Rating { get; set; }

        public Movie(string name, string author, int rating)
        {
            Name = name;
            Author = author;
            Rating = rating;
        }
        public Movie()
        {
            
        }
    }
}
