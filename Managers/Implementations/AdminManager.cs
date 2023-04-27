using System;
using System.Collections.Generic;
using RestaurantApp.Managers.Interface;
using RestaurantApp.Models;

namespace RestaurantApp.Managers.Implementations
{
    
    public class AdminManager : IAdminManager
    {
    public static List<Admin> adminDatabase = new List<Admin>()
    {
        new Admin(1,"Ramat","rahmahomolola@gmail.com","4207","Owner","08141078649",0,"Admin")
    };

        public Admin GetEmail(string email)
        {
            foreach (var admin in adminDatabase)
            {
                if (admin.Email == email) 
                {
                    return admin;
                }
            }
           return null;
        }
        public Admin Get(int id)
        {
            foreach (var admin in adminDatabase)
            {
                if (admin.Id == id) 
                {
                    return admin;
                }
            }
           return null;
        }
        public List<Admin> GetAll()
        {
            return adminDatabase;
        }

        public Admin Login(string email, string pin)
        {
            foreach(var admin in adminDatabase)
            {
                if(admin.Email == email && admin.Pin == pin)
                {
                    return admin;
                }
            }
            return null;
        }

        public Admin Register(string name, string pin, string email, string phoneNumber)
        {
            int id = adminDatabase.Count + 1;
            Admin admin = new Admin(id,name,email,pin,"Staff",phoneNumber,0,"Admin");
            adminDatabase.Add(admin);
            return admin;
        }

        public Admin Update(int id,string name, string pin, string email, string phoneNumber)
        {
            var admin = CheckIfExisted(id);
            if (admin != null )
            {
                admin.Name = name;
                admin.Pin = pin;
                admin.Email = email;
                admin.PhoneNumber = phoneNumber;
                return admin;
            }
            return null;
        }
        public void AdminWallet(int id,decimal amount)
        {
            var admin = CheckIfExisted(id);
            if(admin != null)
            {
                admin.Wallet += amount;
                Console.WriteLine($"{admin.Name},{amount} has been credited to your account and your new balance is {admin.Wallet}");
            }
        
                 

        }
        private Admin CheckIfExisted(int id)
        {
            foreach(var admin in adminDatabase)
            {
                if( admin.Id == id)
                {
                    return admin;
                }
            }
            return null;
        }

        
    }
}