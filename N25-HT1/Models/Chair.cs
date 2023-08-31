using N25_HT1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N25_HT1.Models
{
    internal class Chair : IProduct
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsOrdered { get; set; }
        public double Price { get; set; }
        public double MaxWeight { get; set; }
        public string Material { get; set; }
        public Chair(string name, string description, bool isOrdered, double price, double maxWeight, string material)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            IsOrdered = isOrdered;
            Price = price;
            MaxWeight = maxWeight;
            Material = material;
        }
        public Chair(Chair chair)
        {
            this.Id = chair.Id;
            this.Name = chair.Name;
            this.Description = chair.Description;
            this.IsOrdered = chair.IsOrdered;
            this.Price = chair.Price;
            this.MaxWeight = chair.MaxWeight;
            this.Material = chair.Material;
        }
    }
}
