using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Models
{
    public class Customer : User
    {
        public string Address;
        public decimal Wallet;
        public  Customer(int id,string name,string email,string password,string phoneNumber,string address,decimal wallet,string role):base(id,name, email,password,phoneNumber,role)
        {
            Address = address;
            Wallet = wallet;
        }
    }
}