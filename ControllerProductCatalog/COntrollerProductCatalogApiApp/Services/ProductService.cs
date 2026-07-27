using System.Collections.Generic;
using System.Linq;

namespace Catalog
{
    public static class ProductService
    {
        static List<Product> products = new()
        {
            new Product { Id = 1, Name = "Laptop", Price = 65000 },
            new Product { Id = 2, Name = "Mouse", Price = 500 },
            new Product { Id = 3, Name = "Keyboard", Price = 1200 }
        };

        public static List<Product> GetAll()
        {
            return products;
        }

        public static Product? GetById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public static string Insert(Product product)
        {
            products.Add(product);
            return "Product Added Successfully";
        }

        public static string Update(int id, Product updatedProduct)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
                return "Product Not Found";

            product.Name = updatedProduct.Name;
            product.Price = updatedProduct.Price;

            return "Product Updated Successfully";
        }

        public static string Delete(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
                return "Product Not Found";

            products.Remove(product);
            return "Product Deleted Successfully";
        }
    }
}