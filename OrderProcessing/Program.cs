using System.Reflection.Metadata.Ecma335;
using OrderProcess.Models;
using OrderProcessing.Repository;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

OrderRepository repo = new OrderRepository();

app.MapGet("/api/orders", () =>{return repo.GetAll();});

app.MapGet("/api/orders/{id}", (int id) =>{return repo.GetById(id);});

app.MapPost("api/orders", (Order order) =>{repo.Create(order); return $"Order at OrderId:(order.OrderId) added sucessfully!";});

app.MapPut("/api/orders/{id}",(Order order) =>{repo.Update(order); return $"Order {order.OrderId} updated successfully!";});

app.MapDelete("/api/orders/{id}", (int id) =>{repo.Delete(id); return $"Order with Id:{id} deleted succesfully!";});

app.Run();


