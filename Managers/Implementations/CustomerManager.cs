using System;
using System.Collections.Generic;
using RestaurantApp.Managers.Interface;
using RestaurantApp.Models;

namespace RestaurantApp.Managers.Implementations
{
    public class CustomerManager : ICustomerManager
    {

        public static List<Customer> customerDatabase = new List<Customer>()
        {
       
        new Customer(1,"ola","ola@gmail.com","1234","08023387456","abk",7000,"Customer"),
        new Customer(2,"Maidah","olayinka@gmail.com","7865","0901234567","ibd",10000,"Customer"),
        new Customer(3,"Fizzy","fizzilee@gmail.com","1212","08129387456","abuja",6000,"Customer"),
        new Customer(4,"Lucky","lucky23@gmail.com","1222","09123387456","Lokoja",300,"Customer"),
        new Customer(5,"amaka","amaka87@gmail.com","4464","08023876558","sango",2000,"Customer"),
        new Customer(6,"bamidele","bami@gmail.com","1114","07187454236","idi aba",900,"Customer"),
        
    
        };
       

        
        public void Delete(int id)
        {
            var customer = CheckIfExisted(id); 
            if(customer == null)
            {
                Console.WriteLine("customer does not exist");
            }
            customerDatabase.Remove(customer);
            Console.WriteLine("deleted successfully");
        }

        

        public Customer Get(string email)
        {
            foreach (var customer in customerDatabase)
            {
               if (customer.Email == email)
               {
                return customer;
               } 
            }
            return null;
        }

        public List<Customer> GetAll()
        {
            return customerDatabase;
        }

        public Customer Login(string email, string pin)
        {
            foreach (var customer in customerDatabase)
            {
                if(customer.Email == email && customer.Pin == pin)
                {
                    return customer;
                }
            }
            return null;
        }

        public Customer Create(string name, string pin, string email, string phoneNumber,string address,string role)
        {
            int id = customerDatabase.Count + 1;
            Customer customer = new Customer(id,name,email,pin,phoneNumber,address,0,"Customer");
            customerDatabase.Add(customer);
            return customer;
        }

        public Customer Update(int id,string name, string pin, string email, string phoneNumber,string Address)
        {
            var customer = CheckIfExisted(id);
            if(customer != null)
            {
                customer.Name = name;
                customer.Pin = pin;
                customer.Email = email;
                customer.PhoneNumber = phoneNumber;
                return customer;
            }
            return null;
        }

        

        public void FundWallet(string email,decimal amount)
        {
           var customer = CheckIfExisted(email); 
           if(customer != null)
           {

                if(amount > 0)
                {
               customer.Wallet += amount;
               Console.WriteLine($"Mr/Mrs {customer.Name},you have successfully funded your wallet with {amount} and your new balance is {customer.Wallet}");
                }
                 else
                {
                Console.WriteLine("amount not valid");
                }
            }
        }
        private Customer CheckIfExisted(int id)
        {
            foreach (var customer in customerDatabase)
            {
                if (customer.Id == id)
                {
                   return customer; 
                }
                
            }
            return null;
        }
         private Customer CheckIfExisted(string email)
        {
            foreach (var customer in customerDatabase)
            {
                if (customer.Email == email)
                {
                   return customer; 
                }
                
            }
            return null;
        }
        private Customer CheckIfPinExisted(string pin)
        {
            foreach (var customer in customerDatabase)
            {
                if (customer.Pin == pin)
                {
                   return customer; 
                }
                
            }
            return null;
        }

        public Customer GetByID(int id)
        {
            var customer = CheckIfExisted(id);
            foreach (var item in customerDatabase)
            {
                if(customer.Id == id)
                {
                return customer;
                }
            } 
            return null;  
        }

        public Customer GetByPin(string pin)
        {
            var customer = CheckIfPinExisted(pin);
            foreach (var item in customerDatabase)
            {
                if(customer.Pin == pin)
                {
                    return customer;
                }
            }
            return null;
        }
        public decimal MakePayment(decimal amount,string email)
        {
            foreach (var item in customerDatabase)
            {
                if(item.Email == email)
                {
                    if(item.Wallet >= amount)
                    {
                        item.Wallet-= amount;
                     Console.WriteLine($"Your account has been debited with {amount} and your new balance is {item.Wallet}");
                     return amount;
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Fund");
                        return 0;
                    }
                      
                }
            }
            return 0;
        }
         public void RecievedPayment(decimal amount)
        {
            foreach (var item in customerDatabase)
            {
                if(item.Role == "Admin")
                {
                    item.Wallet+= amount;
                    // Console.WriteLine($"You have successfully credited your account with {amount} and your new balance is {item.Wallet}");
                }
            }
        }

        public Customer Create(string name, string pin, string email, string phoneNumber, string address)
        {
            throw new NotImplementedException();
        }

        public Customer Update(int id, string name, string pin, string email, string phoneNumber, string address, string role)
        {
            throw new NotImplementedException();
        }
    }
}