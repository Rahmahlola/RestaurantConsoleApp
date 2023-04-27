using System;

namespace RestaurantApp.Models
{
    public class Rider : User
    {
        public Rider(int id,string name,string email,string pin,string staff,string phoneNumber,string role):base(id,name, email,pin,phoneNumber,role)
        {
            Id =id;
            Name = name;
            Email= email;
            Pin = pin;
            PhoneNumber = phoneNumber;
            Role = role;

        }
    }
}