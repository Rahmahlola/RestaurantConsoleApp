using System;
using System.Collections.Generic;
using RestaurantApp.Models;

namespace RestaurantApp.Managers.Interface
{
    public interface ICustomerManager
    {
        public Customer Create(string name, string pin, string email, string phoneNumber,string address,string role);
        public Customer Get(string email);
        public Customer GetByID(int id);
        public Customer GetByPin(string pin);
        public List<Customer> GetAll();
        public Customer Update(int id,string name, string pin, string email, string phoneNumber,string address,string role);
        public void FundWallet(string email , decimal amount);
        public void Delete(int id);
        public Customer Login(string email, string pin);
        public decimal MakePayment(decimal amount,string pin);
        public void RecievedPayment(decimal amount);
    }
}




