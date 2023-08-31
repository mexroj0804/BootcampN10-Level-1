using N25_HT1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N25_HT1.Models
{
    internal class ProductFilterDataModel
    {
        public List<string> ProductTypes { get; }

        public ProductFilterDataModel(List<IProduct> products)
        {
            if (products.Count == 0)
                ProductTypes = new();
            else
                ProductTypes = products.Select(item => item.GetType().FullName).Distinct().ToList();
        }
    }
}
