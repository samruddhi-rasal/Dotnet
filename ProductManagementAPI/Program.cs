var builder = WebApplication.CreateBuilder(args);

// Register application services
builder.Services.AddControllers();

builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddScoped<IProductRepository, ProductRepository>();

var app = builder.Build();

// Configure HTTP pipeline
app.UseHttpsRedirection();

app.MapControllers();

app.Run();