using System;
using System.Collections.Generic;
using RestaurantApp.Manager.Interface;
using RestaurantApp.Models;

namespace RestaurantApp.Managers.Implementations
{
    public class ProductManager : IProductManager
    {
        public static List<Product> productDatabase = new List<Product>()
        {
          new Product(1,"Amala with Gbegiri Soup ",600,1,true), 
          new Product(2,"Amala with Gbegiri Soup Only",450,1,true),
          new Product(3,"Amala with Ewedu Soup ",600,1,true),
          new Product(4,"Amala with Ewedu Soup Only",450,1,true),
          new Product(5,"Amala with Okro Soup ",600,1,true),
          new Product(6,"Amala with Okro Soup Only",450,1,true),
          new Product(7,"Abacha and Ugba", 600,1,false),
          new Product(8,"Afang Soup with Fufu", 600,1,true),
          new Product(9,"Bread with Ewa Agoyin", 1000,1,true),
          new Product(10,"Banga Soup with Starch", 600,1,true),
          new Product(11,"Roasted Plantain(Boli) with Ponmo Sauce", 1500,1,true),
          new Product(12,"Yam Porridge with Beef Stew", 1000,1,true),
          new Product(13,"Eba with Efo Riro", 600,1,true),
          new Product(14,"Eba with Egusi Soup", 600,1,true),
          new Product(15,"Pounded Yam with Egusi Soup", 600,1,true),
          new Product(16,"Ofada Rice with Snail Sauce", 600,1,true),
          new Product(17,"Tuwo Shinkafa with Groundnut Soup", 600,1,true),



          
        };
        public Product Delete(int id)
        {
            foreach (var product in productDatabase)
            {
                if (product.Id == id)
                {
                    return product;
                }
            }

            return null;
        }

        public Product Get(int id)
        {
            foreach (var product in productDatabase)
            {

                if (product.Id == id)
                {
                   
                    return product;
                }
            }

            return null;
        }
        public Product GetPrice(decimal price)
        {
            foreach (var product in productDatabase)
            {
                if(product.Price == price)
                {
                    return product;
                }
            }
            return null;
        }

        public List<Product> GetAll()
        {
            return productDatabase;
        }

        public Product Register(string productName, decimal price, int quantity)
        {
            int id = productDatabase.Count + 1;
            Product product = new Product(id,productName,price,quantity,true);
            productDatabase.Add(product);
            return product;
        }

       

        public Product Update(int id,string productName, decimal price)
        {
         var product = CheckIfExisted(id);
            if(product != null)
            {
                product.ProductName = productName;
                product.Price = price;
                return product;
            }
            return null;
        }

        private Product CheckIfExisted(int id)
        {
            foreach (var product in productDatabase)
            {
                if (product.Id == id)
                {
                   return product; 
                }
                
            }
            return null;
        }

        public Product Get(decimal price)
        {
            
            foreach (var product in productDatabase)
            {
                if(product.Price == price)
                {
                    return product;
                }
            }
            return null;
        }
    }
}