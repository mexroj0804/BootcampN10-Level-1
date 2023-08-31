using N25_HT1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N25_HT1.Models
{
    public class Monitor : IProduct
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsOrdered { get; set; }
        public double Price { get; set; }
        public double DisplaySize { get; set; }
        public double RefreshRate { get; set; }
        public Monitor(string name, string description, bool isOrdered, double price, double displaySize, double refreshRate)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            IsOrdered = isOrdered;
            Price = price;
            DisplaySize = displaySize;
            RefreshRate = refreshRate;
        }
        public Monitor(Monitor monitor)
        {
            Id = monitor.Id;
            Name = monitor.Name;
            Description = monitor.Description;
            IsOrdered = monitor.IsOrdered;
            Price = monitor.Price;
            DisplaySize = monitor.DisplaySize;
            RefreshRate = monitor.RefreshRate;
        }
    }
}
