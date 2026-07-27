using  Catalog;
using Entities;
var builder = WebApplication.CreateBuilder(args); //instance of WebApplication Builder
var app = builder.Build(); //instance of WebApplication
//api endpoint url(action) -----------callback function (handler)
app.MapGet("/api/customers", () =>{return  "tanvi, nikita, sachin";});
app.MapGet("/api/cart", () =>{return  "laptop-2, samsung-6, earbuds-8";});
app.MapGet("/api/orders", () =>{return  "ord123, ord432, ord987";});

//CRUD APIs

//GET ALL PRODUCTS
app.MapGet("/api/products", () =>{return ProductService.GetAll();});

//GET PRODUCT BY ID
app.MapGet("/api/products/{id}", (int id) =>{return ProductService.GetById(id);});

//INSERT PRODUCT
//app.MapPost("/api/products",()=>{ return ProductService.Insert(new Entities.Product{Id = 4, Title = "Tablet", Price = 15000});});
app.MapPost("/api/products", (Product product) =>
{
    return ProductService.Insert(product);
});

//UPDATE
app.MapPut("/api/products/{id}", (int id, Product product) =>
{
    return ProductService.Update(id, product);
});

//DELETE
app.MapDelete("/api/products/{id}", (int id) =>
{
    return ProductService.Delete(id);
});

app.Run();