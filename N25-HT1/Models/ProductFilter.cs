using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N25_HT1.Models
{
    internal class ProductFilter
    {
        public string Name { get; set; }
        public Type Type { get; set; }

        public ProductFilter(string name, Type type)
        {
            Name = name;
            Type = type;
        }
    }
}
