using System.Text.Json;

public class ProductRepository : IProductRepository
{
    private readonly string _filePath;

    public ProductRepository(IWebHostEnvironment environment)
    {
        _filePath = Path.Combine(
            environment.ContentRootPath,
            "Data",
            "products.json"
        );
    }

    public async Task<List<Product>> GetAllAsync()
    {
        if (!File.Exists(_filePath))
            return new List<Product>();

        var json = await File.ReadAllTextAsync(_filePath);

        return JsonSerializer.Deserialize<List<Product>>(json)
               ?? new List<Product>();
    }

    public async Task<Product?> GetByIdAsync(int id)
    {
        var products = await GetAllAsync();

        return products.FirstOrDefault(p => p.Id == id);
    }
}
