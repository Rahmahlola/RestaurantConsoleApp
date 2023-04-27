using System;
using System.Collections.Generic;
using RestaurantApp.Models;

namespace RestaurantApp.Manager.Interface
{
    public interface IProductManager
    {
        public Product Register(string productName, decimal price, int quantity);
        public Product Get(int id);
        public Product GetPrice(decimal price);
        public List<Product> GetAll();
        public Product Update(int id,string productName, decimal price);
        public Product Delete(int id);
        
    }
}