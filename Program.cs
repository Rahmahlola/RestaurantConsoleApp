using System;
using RestaurantApp.Managers.Implementations;
using RestaurantApp.Menu;
namespace RestaurantApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Menu();
        }
    }
}
