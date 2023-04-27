using System;
using System.Collections.Generic;
using RestaurantApp.Models;

namespace RestaurantApp.Manager.Interface
{
    public interface IRiderManager
    {
        public Rider Register(string name, string pin, string email, string phoneNumber);
        public Rider Get(int id);
        public List<Rider> GetAll();
        public Rider Update(string name, string pin, string email, string phoneNumber);
        public Rider Delete(int id);
        public Rider Login(string email, string pin);
    }
}