using System;
using System.Collections.Generic;


namespace RestaurantApp.Models
{
    public class Order
    {
        public int Id;
        public DateTime Time;
        public string Address;
        public int FoodId;
        public string CustomerEmail;
        public decimal Amount;
        // public string Status;

        public Order(int id,DateTime time,string address,int foodId, string customerEmail, decimal amount)
        {
            Id = id; 
            Time = time;
            Address = address;
            FoodId = foodId;
            CustomerEmail = customerEmail;
            Amount = amount;
        }

    }
}