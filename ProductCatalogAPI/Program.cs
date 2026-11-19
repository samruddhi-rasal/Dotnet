var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/api/products",()=>{ return "Gerbera, Rose, Jasmine, Lily";});  //R
app.MapPost("/api/products",()=>{return "Louts added";});  //C
app.MapPut("/api/products",()=>{ return "Rose updated";});      //U
app.MapDelete("/api/products",()=>{return " Jasmine Deleted";});       //D
app.Run();