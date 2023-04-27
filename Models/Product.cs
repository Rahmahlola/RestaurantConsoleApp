using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Models
{
    public class Product
    {
        public int Id;
        public string ProductName;
        public decimal Price;
        public int Quantity;
        public bool IsAvailable;
        
        public Product(int id, string productName, decimal price,int quantity,bool isAvailable)
        {
            Id = id;
            ProductName = productName;
            Price = price;
            Quantity = quantity;
            IsAvailable = isAvailable;
        }
    }
}