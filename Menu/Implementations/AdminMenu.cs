using System;
using RestaurantApp.Manager.Interface;
using RestaurantApp.Managers.Implementations;
using RestaurantApp.Managers.Interface;
using RestaurantApp.Menu.Interface;

namespace RestaurantApp.Menu
{
    public class AdminMenu : IAdminMenu
    {
        IProductManager productManager = new ProductManager();
        IAdminManager adminManager = new AdminManager();
        IRiderManager riderManager = new RiderManager();
        ICustomerManager customerManager = new CustomerManager();
        public void AdminMain()
        {
            Console.WriteLine("Enter 1 to Create Product Menu\nEnter 2 to View all Products\nEnter 3 to View all Customers\nEnter 4 to View all Riders\nEnter 5 to View Wallet\nEnter 6 to Log Out");
            int input = int.Parse(Console.ReadLine());
            if(input == 1)
            {
              CreateProductMenu(); 
              Console.WriteLine("Enter 0 to Go Back :");
                int a =int.Parse(Console.ReadLine());
                if(a == 0)
                {
                    AdminMain();
                } 
            }
            else if(input == 2)
            {
                ViewAllProducts();
                Console.WriteLine("Enter 0 to Go Back :");
                int a =int.Parse(Console.ReadLine());
                if(a == 0)
                {
                    AdminMain();
                }
            }
            else if(input == 3)
            {
                ViewAllCustomers();
                Console.WriteLine("Enter 0 to Go Back :");
                int a =int.Parse(Console.ReadLine());
                if(a == 0)
                {
                    AdminMain();
                }
            }
            else if(input == 4)
            {
                ViewAllRiders();
                Console.WriteLine("Enter 0 to Go Back :");
                int a =int.Parse(Console.ReadLine());
                if(a == 0)
                {
                    AdminMain();
                }
            }
            else if (input == 5)
            {
                ViewWallet();
                Console.WriteLine("Enter 0 to Go Back :");
                int a =int.Parse(Console.ReadLine());
                if(a == 0)
                {
                    AdminMain();
                }
                
            }
            else if (input == 6)
            {
                LogOut();
            }


        }

        public void CreateProductMenu()
        {
            Console.WriteLine("Enter Product Name :");
            string name = Console.ReadLine();
            Console.WriteLine($"Enter Price for {name}:");
            decimal price =  decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the Quantity for {name}:");
            int quantity = int.Parse(Console.ReadLine());
            var y =productManager.Register(name,price,quantity);
            System.Console.WriteLine("You have successfully added to the menu");
            
        }

        public void LogOut()
        {
           MainMenu m = new MainMenu();
              m.Menu(); 
        }

        public void ViewAllCustomers()
        {
            var customers = customerManager.GetAll();
            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.Id}\t {customer.Name}\t {customer.Email}\t {customer.Pin}\t {customer.PhoneNumber}\t {customer.Address}\t");
            }
           
        }

        public void ViewAllProducts()
        {
           var products = productManager.GetAll();
            foreach (var product in products)
            {
              Console.WriteLine($"{product.Id}{product.ProductName}\t {product.Price}\t {product.Quantity}");
            } 
        

        }

        public void ViewAllRiders()
        {
            var riders = riderManager.GetAll();
            foreach (var rider in riders)
            {
                Console.WriteLine($"{rider.Id}\t{rider.Name}\t {rider.Email}\t {rider.Pin}\t {rider.PhoneNumber}\t {rider.Role}");
            }
            
        }

        public void ViewWallet()
        {
            var wallets = adminManager.GetAll();
            foreach (var wallet  in wallets)
            {
               Console.WriteLine($"Admin wallet:{wallet.Wallet}") ;
            }
            
        }
    }
}