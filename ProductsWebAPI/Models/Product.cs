//Models : represent product data 

namespace ProductsWebAPI.Models;
public class Product
{
    public int id{get; set;}
    public string name{get; set;} = "";
    public decimal price {get; set;}
    public string category {get; set;} = "";
   
}

//A model reprsents the structure of the bussiness data  
