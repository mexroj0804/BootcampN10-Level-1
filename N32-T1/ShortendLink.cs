using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N32_T1
{
    public class ShortendLink
    {
        public int Id { get; set; }
        public string OriginalUrl { get; }
        public string ShortedUrl { get; }

        public ShortendLink(int id, string originalurl, string shortedurl)
        {
            Id = id;
            OriginalUrl = originalurl;
            ShortedUrl = shortedurl;
        }
        public override bool Equals(object? obj)
        {
            if ((obj != null) && base.GetHashCode() == obj.GetHashCode()) return true;
            else return false;
        }
    }
}
