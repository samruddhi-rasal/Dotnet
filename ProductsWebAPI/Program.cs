
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

// JSON file location
 string filePath = Path.Combine(app.Environment.ContentRootPath, "products.json");

// JSON serialization settings
var options = new JsonSerializerOptions
{
    WriteIndented = true,
    PropertyNameCaseInsensitive = true
};
// Read products from JSON file
async Task<List<Product>> ReadProducts()
{
    if (!File.Exists(filePath))
    {
        return new List<Product>();
    }

    string json = await File.ReadAllTextAsync(filePath);

    return JsonSerializer.Deserialize<List<Product>>(json, options) ?? new List<Product>();
}

// Save products into JSON file
async Task SaveProducts(List<Product> products)
{
    string json = JsonSerializer.Serialize(products, options);
    await File.WriteAllTextAsync(filePath, json);
}

// ----------------------------------
// GET: Retrieve all products
// ----------------------------------
app.MapGet("/api/products", async () =>
{
    var products = await ReadProducts();

    return Results.Ok(products);
});

// ----------------------------------
// GET: Retrieve product by ID
// ----------------------------------
app.MapGet("/api/products/{id:int}", async (int id) =>
{
    var products = await ReadProducts();

    var product = products.FirstOrDefault(p => p.Id == id);

    if (product == null)
        return Results.NotFound();

    return Results.Ok(product);
});

// ----------------------------------
// POST: Add a new product
// ----------------------------------
app.MapPost("/api/products", async (Product product) =>
{
    var products = await ReadProducts();

    if (string.IsNullOrWhiteSpace(product.Name))
        return Results.BadRequest("Product name is required.");

    if (product.Price < 0)
        return Results.BadRequest("Price cannot be negative.");

    product.Id = products.Count == 0
        ? 1
        : products.Max(p => p.Id) + 1;

    products.Add(product);

    await SaveProducts(products);

    return Results.Created(
        $"/api/products/{product.Id}", product
    );
});

// ----------------------------------
// PUT: Update an existing product
// ----------------------------------
app.MapPut("/api/products/{id:int}", async (
    int id, Product updatedProduct) =>
{
    var products = await ReadProducts();

    var product = products.FirstOrDefault( p => p.Id == id);

    if (product == null)
        return Results.NotFound();

    if (string.IsNullOrWhiteSpace(updatedProduct.Name))
        return Results.BadRequest("Product name is required.");

    if (updatedProduct.Price < 0)
        return Results.BadRequest("Price cannot be negative.");

    product.Name = updatedProduct.Name;
    product.Price = updatedProduct.Price;
    product.Category = updatedProduct.Category;

    await SaveProducts(products);

    return Results.Ok(product);
});

// ----------------------------------
// DELETE: Remove a product
// ----------------------------------
app.MapDelete("/api/products/{id:int}", async (int id) =>
{
    var products = await ReadProducts();

    var product = products.FirstOrDefault(p => p.Id == id);

    if (product == null)
        return Results.NotFound();

    products.Remove(product);

    await SaveProducts(products);

    return Results.Ok("Product deleted successfully.");
});

app.Run();

// ----------------------------------
// Product Model
// ----------------------------------
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public decimal Price { get; set; }
    public string Category { get; set; } = "";
}
