using N32_T3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N32_T3.Services
{
    public class ProductService
    {
        private static ProductService _instance;

        private ProductService()
        {

        }

        public static ProductService GetInstance()
        {
            if (_instance is null)
                _instance = new ProductService();

            return _instance;
        }


        List<Product> products = new();

        public void Add(int id, string name, string description)
        {
            products.Add(new Product(id, name, description));
        }

        public void Clone(int id)
        {
            var find = products.FirstOrDefault(x => x.Id == id);

            if (find != null)
            {
                var copy = new Product(find);
                products.Add(copy);
            }
        }
        public void Display()
        {
            foreach (var item in products)
            {
                Console.WriteLine($"Id: {item.Id} Name: {item.Name} Description: {item.Description}");
            }
        }
    }
}
