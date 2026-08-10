using System;
using System.Net.Http.Headers;
using ECommerce.Models;
namespace Ecommerce.Models;

    public class CartItem
    {
        public Product Product{get; set;}

        public int Quantity{get; set;}

        public double UnitPrice 
        {
            get
            {
                return Product.Price;
            }
        }
        public double TotalAmount
        {
            get
            {
                return Product.Price * Quantity;
            }
        }
        public override string ToString()
    {
        return $"{Product.Name} Qty: {Quantity} Total:{TotalAmount}";
    
        }
    }
    