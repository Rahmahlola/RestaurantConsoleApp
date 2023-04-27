using System;
using System.Collections.Generic;
using RestaurantApp.Models;

namespace RestaurantApp.Manager.Interface
{
    public interface IOrderManager
    {
        public Order ViewList(string address,DateTime time,string status);
        public Order Get(int id);
        public Order Get(DateTime time);
        public Order GetAll();
        public Order Create(int id,string address, int foodId, string customerEmail, decimal amount);
    }
}