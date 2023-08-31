using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N23_HT1.Models
{
    internal class Product
    {
        public string Name { get; set; }
        public int Star { get; set; }
        public int Inventory { get; set; }

        public Product(string name, int star, int inventory)
        {
            Name = name;
            Star = star;
            Inventory = inventory;
        }
    }
}
