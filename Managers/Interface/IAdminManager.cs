using System;
using System.Collections.Generic;
using RestaurantApp.Models;

namespace RestaurantApp.Managers.Interface
{
    
    public interface IAdminManager
    {

       public Admin GetEmail(string email);
       public Admin Get(int id);
       public List<Admin> GetAll();
       public Admin Update(int id,string name, string pin, string email, string phoneNumber);
     public Admin Login(string email, string pin);
     public void AdminWallet(int id,decimal amount);

    }
}