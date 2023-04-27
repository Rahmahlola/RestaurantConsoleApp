using System;
using RestaurantApp.Manager.Interface;
using RestaurantApp.Managers.Implementations;
using RestaurantApp.Managers.Interface;
using RestaurantApp.Menu.Interface;

namespace RestaurantApp.Menu
{
    public class MainMenu
    {
        ICustomerManager customerManager = new CustomerManager();
        IAdminManager adminManager = new AdminManager();
        IProductManager productManager = new ProductManager();
        IRiderManager riderManager = new RiderManager();
        ICustomerMenu customerMenu = new CustomerMenu();
        IAdminMenu adminMenu = new AdminMenu();
        IRiderMenu riderMenu = new RiderMenu();

        public void Menu()
        {
            Console.WriteLine("Welcome To Owambe Kitchen");
            Console.WriteLine("Enter 1 to Sign up\nEnter 2 to Log in ");
            int input = int.Parse(Console.ReadLine());
            if(input == 1)
            {
               RegisterCustomerMenu();
            }
            else if (input == 2)
            {
            
                 LoginMenu();
            }
            else
            {
                Console.WriteLine("Invalid option");
                Menu();
            }

        }
             public void RegisterCustomerMenu()
            {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your Email: ");
            string email = Console.ReadLine();
            Console.Write("Enter Pin: ");
            string pin = Console.ReadLine();
            Console.Write("Enter PhoneNumber:");
            string phoneNumber = Console.ReadLine();
            Console.Write("Enter your Address: ");
            string address = Console.ReadLine();
            var x = customerManager.Create(name,pin,email,phoneNumber,address,"customer");
           
                Console.WriteLine("You have sign up successfully");
                Menu();
            }
            

        public void GetAll()
        {
            var customers = customerManager.GetAll();
            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.Id}\t {customer.Name}\t {customer.Email}\t {customer.Pin}\t {customer.PhoneNumber}\t {customer.Address}\t");
            }
        }
       
        public void LoginMenu()
        {
            Console.Write("Enter your Email: ");
            string email = Console.ReadLine();
            Console.Write("Enter your Pin: ");
            string pin = Console.ReadLine();
    
            var signin1 = adminManager.Login(email,pin);
            var signin2 = customerManager.Login(email,pin);
            var signin3 = riderManager.Login(email,pin);
            
            

                if(signin1 != null)
                {
                    adminMenu.AdminMain();
                }
                else if(signin2 != null)
                {
                    customerMenu.CustomerMain();
                }
                else if (signin3 != null)
                {
                    riderMenu.RiderMain();
                }
                else
            {
                System.Console.WriteLine("Invalid Name or Password");
                
            }
        
        } 
     
          
    }
}