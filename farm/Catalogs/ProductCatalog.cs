using System;
using farm.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace farm
{
    public class ProductCatalog
    {

        private Dictionary<int, Product> products { get; }

        private static ProductCatalog _instance;

        private ProductCatalog()
        {
            products = new Dictionary<int, Product>();

            products.Add(1, new Product() { Id = 1, Price = 99.9, Name = "Meal 1", Description = "Lorem ipsum...", Photo = "https://images.unsplash.com/photo-1448907503123-67254d59ca4f?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1949&q=80" }) ;
        }

        public static ProductCatalog Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ProductCatalog();
                }
                return _instance;
            }
        }

        public Dictionary<int, Product> AllProducts()
        {
            return products;
        }

        public void AddProduct(Product product)
        {
            if (!(products.Keys.Contains(product.Id)))
                products.Add(product.Id, product);
        }

        public Product GetProduct(int id)
        {
            return products[id];
        }

        public void UpdateProduct(Product product)
        {
            if (product != null)
            {
                products[product.Id] = product;
            }
        }

        public void DeleteProduct(Product product)
        {
            if (product != null)
            {
                products.Remove(product.Id);
            }

        }

        public int CountProduct()
        {
            return products.Count();
        }
    }
}
