using System;
using System.Collections.Generic;
using RestaurantApp.Manager.Interface;
using RestaurantApp.Models;
namespace RestaurantApp.Managers.Implementations
{
    public class OrderManager : IOrderManager
    {
      public  static List<Cart>Cart = new List<Cart>();
        
        public static List<Order> orderDatabase = new List<Order>();
        

        public Order Get(int id)
        {
            foreach (var order in orderDatabase)
            {
               if (order.Id == id)
               {
                return order;
               } 
            }
            return null;
        }

        public Order Get(DateTime time)
        {
            foreach (var order in orderDatabase)
            {
                if(order.Time == time)
                {
                    return order;
                }
            }
            return null;
        }

        public List<Order> GetAll()
        {
            return orderDatabase;
        }

        // public Order ViewList(string address,DateTime time,Dictionary<string, string> cart,string status)
        // {
        //     var orderExist = CheckIfExist(address);
        //     if (orderExist == null)
        //     {
        //         Order order = new Order(orderDatabase.Count + 1,time, address,"Available");
        //         orderDatabase.Add(order);
        //         return order;
        //     }
        //     return null;
        // }
        private Order CheckIfExist(string address)
        {
            foreach (var order in orderDatabase)
            {
                if( order.Address == address)
                {
                    return order;
                }
            }
            return null;
        }

        Order IOrderManager.GetAll()
        {
            throw new NotImplementedException();
        }

        public Order ViewList(string address, DateTime time, string status)
        {
            throw new NotImplementedException();
        }

        public Order Create(int id,string address, int foodId, string customerEmail, decimal amount)
        {

            Order order = new Order(id,DateTime.Now,address,foodId,customerEmail,amount);

            orderDatabase.Add(order);
            return order;
            
        }
    }
}