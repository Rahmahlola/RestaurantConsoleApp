using System;
using RestaurantApp.Manager.Interface;
using RestaurantApp.Managers.Implementations;
using RestaurantApp.Managers.Interface;
using RestaurantApp.Menu.Interface;
using RestaurantApp.Models;

namespace RestaurantApp.Menu
{
    public class CustomerMenu : ICustomerMenu
    {
        IProductManager productManager = new ProductManager();
        IAdminManager adminManager = new AdminManager();
        IRiderManager riderManager = new RiderManager();
        ICustomerManager customerManager = new CustomerManager();
        IOrderManager orderManager = new  OrderManager();

        public void CustomerMain()
        {
            Console.WriteLine("Enter 1 to View Food Menu\nEnter 2 to View Promo\nEnter 3 to View Special Promo\nEnter 4 to Fund Wallet\nEnter 5 to Log out");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                FoodMenu();
            }
            else if (input == 2)
            {
                ViewPromo();
            }
            else if (input == 3)
            {
                ViewSpecialPromo();
            }
            else if (input == 4)
            {
                FundWalletMenu();
            }
            else if (input == 5)
            {
                LogOut();
            }
        }
        public void FoodMenu()
        {
            var menus = productManager.GetAll();
            foreach (var menu in menus)
            {
                Console.WriteLine($"{menu.Id}\t {menu.ProductName}\t {menu.Price}\t {menu.Quantity}");
            }
            Console.WriteLine("Enter Product id:");
            int id = int.Parse(Console.ReadLine());
            var foodmenu = productManager.Get(id);
            if(foodmenu != null)
            {
               Console.WriteLine($"{foodmenu.ProductName}\t{foodmenu.Price}\t{foodmenu.Quantity}"); 
                 Console.WriteLine("Enter your Email for Confirmation of order:");
                string email = Console.ReadLine();
                var customer = customerManager.Get(email);
                if(customer == null)
                {
                    Console.WriteLine($"invalid customer");
                    FoodMenu();
                }
                else
                {
                    var amount =  customerManager.MakePayment(foodmenu.Price,email);
                    if(amount != foodmenu.Price)
                    {
                        FoodMenu();
                    }
                    else
                    {
                        int length = OrderManager.orderDatabase.Count ;
                        orderManager.Create(length++,customer.Address,foodmenu.Id,customer.Email,amount);
                       Cart cart = new Cart(customer.Email,foodmenu.ProductName,foodmenu.Price,foodmenu.Quantity);
                       OrderManager.Cart.Add(cart);
                        //  customerManager.RecievedPayment(amount);
                        //  var carts = OrderManager.Cart;
                        //  var orders = OrderManager.orderDatabase;
                        Console.WriteLine("Thanks for Patronizing our Kitchen                       .......we dey for una");
                        
                        MainMenu m = new MainMenu();
                        m.Menu();
                    }
                }
                
            }
            else
            {
                Console.WriteLine("wrong input");
            }
               
        }
        
        
        public void ViewPromo()
        {
            Console.WriteLine("1. Order 3 Plates of Food Menu for Free Set of Spoon\n2.Order 4 Plates of Food Menu for Free Set of Plate\n3.Order 5 Plates of Food Menu For Free Set of ServingTray ");
            MainMenu m = new MainMenu();
             m.Menu();
        }
        public void ViewSpecialPromo()
        {
              Console.WriteLine("1.Order 6 Plates of Food Menu for Free Set of Jugs\n2.Order 7 Plates of Food Menu for Free Set of Mug\n3.Order 8 Plates of Food Menu For Free Set of FryingPan\n4.Order All For FamilyFreeVoucher");
              MainMenu m = new MainMenu();
             m.Menu();
        }
        public void FundWalletMenu()
        {
             Console.WriteLine("Enter mail :");
            string mail = Console.ReadLine();
            Console.WriteLine("Enter amount :");
            decimal amount = decimal.Parse(Console.ReadLine());
             customerManager.FundWallet(mail, amount);
            CustomerMain();
        }

        public void LogOut()
        {
         MainMenu m = new MainMenu();
          m.Menu();
        }

        

    }
}
