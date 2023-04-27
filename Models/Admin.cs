using System;


namespace RestaurantApp.Models
{
    public class Admin : User
    {
        public string Staff;
        public decimal Wallet;
        public Admin(int id, string name, string email, string pin, string staff, string phoneNumber, decimal wallet, string role) : base(id, name, email, pin, phoneNumber, role)
        {
            Staff = staff;
            Wallet = wallet;
        }
    }
}