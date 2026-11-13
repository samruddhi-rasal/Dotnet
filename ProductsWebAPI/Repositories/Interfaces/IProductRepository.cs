using ProductsWebAPI.Models;

namespace ProductsWebAPI.Repositories.Interfaces;

public interface IProductReppository
{
    Task<List<Product>> GetAllAsync();
    Task<Product?> GetByIdAsync(int id);
    Task<Product> AddAsync(Product product);
    Task<bool> UpdateAsync(int id, Product product);
    Task<bool> DeleteAync(int id);
}