using Catalog;

var builder = WebApplication.CreateBuilder(args);

// Enable Controllers
builder.Services.AddControllers();

var app = builder.Build();

// Map Controllers
app.MapControllers();

app.Run();