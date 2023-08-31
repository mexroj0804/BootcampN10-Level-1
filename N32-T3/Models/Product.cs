using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace N32_T3.Models
{
    public class Product
    {
        private string _name;
        private string _description;
        public int Id { get; init; }
        public string Name {
            get => _name;
            private set
            {
                if (!string.IsNullOrWhiteSpace(_name))
                    _name = value;
            }
        }
        public string Description {
            get => _description;
            private set 
            {
                if (!string.IsNullOrWhiteSpace(_description))
                    _description = value;
            }
        }

        public Product(int id, string name, string description)
        {
            Id = id;
            _name = name;
            _description = description;
        }

        public Product(Product product)
        {
            Id = product.Id;
            Name = product.Name;
            Description = product.Description;
        }
    }
}
