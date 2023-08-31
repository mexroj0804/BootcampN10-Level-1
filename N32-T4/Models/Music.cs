using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N32_T4.Models
{
    public class Music
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SingerName { get; set; }
        public Music(int id, string name, string singername)
        {
            Id = id;
            Name = name;
            SingerName = singername;
        }
    }
}
