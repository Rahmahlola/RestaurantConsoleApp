using System;
using System.Collections.Generic;
using RestaurantApp.Manager.Interface;
using RestaurantApp.Managers.Implementations;
using RestaurantApp.Managers.Interface;
using RestaurantApp.Menu.Interface;
namespace RestaurantApp.Menu
{
    public class RiderMenu :IRiderMenu
    {
        IProductManager productManager = new ProductManager();
        IAdminManager adminManager = new AdminManager();
        IRiderManager riderManager = new RiderManager();
        ICustomerManager customerManager = new CustomerManager();
        IOrderManager orderManager = new OrderManager();

        

        public void  RiderMain()
        {
        Console.WriteLine("Enter 1 to View Order\nEnter 2 to LogOut");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                ViewAllOrder();
            }
            else if(input == 2)
            {
                LogOut();
            }
        }
        public void ViewAllOrder()
        {
             
            
             
        }

        public void LogOut()
        {
            MainMenu m = new MainMenu();
             m.Menu();
        }
    }

        
}