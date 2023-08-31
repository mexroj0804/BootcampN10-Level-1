using N25_HT1.Interfaces;
using N25_HT1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N25_HT1.Service
{
    internal class ProductService : IProductService
    {
        public List<IProduct> Inventory { get; set; }
        public ProductService()
        {
            Inventory = new List<IProduct>();
        }

        public void Add(IProduct product)
        {
            Inventory.Add(product);
        }

        public ProductFilterDataModel GetFilterDataModel()
        {
            var result = new ProductFilterDataModel(Inventory);
            return result;
        }

        public List<IProduct> Get(ProductFilterDataModel filterDataModel)
        {
            var filter = Inventory.Where(item => filterDataModel.ProductTypes.Contains(item.GetType().FullName)).ToList();
            var result = new List<IProduct>(filter);
            return result;
        }

        public IProduct Order(Guid productId)
        {
            var result = Inventory.Find(product => product.Id == productId);
            result.IsOrdered = true;
            return CopyProduct(result) is null
                ? throw new Exception("Product not found")
                : CopyProduct(result);

        }

        private IProduct CopyProduct(IProduct product)
        {
            if (product is Models.Monitor monitor)
            {
                var obj = new N25_HT1.Models.Monitor(monitor);
                return obj;
            }
            else if (product is Chair chair)
            {
                var obj = new Chair(chair);
                return obj;
            }
            else if (product is Laptop laptop)
            {
                var obj = new Laptop(laptop);
                return obj;
            }
            return null;
        }

        public IProduct Return(Guid productId)
        {
            var result = Inventory.Find(p => p.Id == productId);
            result.IsOrdered = false;
            return CopyProduct(result) is null
                ? throw new Exception("Product not found")
                : CopyProduct(result);

        }
    }
}
