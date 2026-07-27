namespace Catalog;
using System.Collections.Generic;
using Entities;

public class ProductService
{
    static List<Product> products = new List<Product>()
    {
        new Product{Id=1, Title="Laptop", Price=50000},
        new Product{Id=2, Title="Samsung", Price=20000},
        new Product{Id=3, Title="Earbuds", Price=2000},  
    };

    //GET ALL 
    public static List<Product> GetAll()
    {
        return products;
    }

    //GET BY ID
    public static Product? GetById(int id)
    {
        return products.FirstOrDefault(p => p.Id == id);
    }

    //INSERT
    public static Product Insert(Product product)
    {
        products.Add(product);
        return product;
    }

    //UPDATE
    public static string Update(int id, Product updatedProduct)
    {
        // var product = products.FirstOrDefault(p => p.Id == id);
        // if (product == null)
        // {
        //     return "Product not found.";
        // }
        foreach(var product in products)
        {
            if(product.Id == id)
            {
                product.Title = updatedProduct.Title;
                product.Price = updatedProduct.Price;
                return "Product updated successfully.";
            }
        }
        return "Product not found.";
       
    }

    //DELETE
    public static string Delete(int id)
    {
        // var product = products.FirstOrDefault(p => p.Id == id);
        // if (product == null)
        // {
        //     return "Product not found.";
        // }
        foreach(var product in products)
        {
            if(product.Id == id)
            {
                products.Remove(product);
                return "Product deleted successfully.";
            }
        }
        return "Product not found.";
    }
}