using N25_HT1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N25_HT1.Interfaces
{
    internal interface IProductService
    {
        List<IProduct> Inventory { get; set; }
        public void Add(IProduct product);
        public ProductFilterDataModel GetFilterDataModel();

    }
}
