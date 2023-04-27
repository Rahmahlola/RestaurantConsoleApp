using System;

namespace RestaurantApp.Models
{
    public class User
    {
        public int Id;
        public string Name;
        public string Email;
        public string Pin;
        public string PhoneNumber;
        public string Role;

        public User(int id,string name,string email,string pin,string phoneNumber,string role)
        {
            Id = id;
            Name = name;
            Email = email;
            Pin = pin;
            PhoneNumber = phoneNumber;
            Role = role;

        }

    }
}