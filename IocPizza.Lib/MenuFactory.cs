using System.Collections.Generic;

namespace IocPizza.Lib
{
    public class MenuFactory : IMenuFactory
    {
        public IMenu CreateMenu()
        {
            var menu = new Menu();
            menu.MenuItems = new List<MenuItem>
                                 {
                                     new MenuItem { Title = "Sicilian", Price = 12.88m },
                                     new MenuItem { Title = "Neapolitan", Price = 11.34m },
                                     new MenuItem { Title = "Spicy Steak and Potato", Price = 12.49m },
                                     new MenuItem { Title = "Hawaiian", Price = 10.49m },
                                     new MenuItem { Title = "BBQ Chicken", Price = 10.99m },
                                     new MenuItem { Title = "Deluxe", Price = 11.49m },
                                     new MenuItem { Title = "Butter Chicken", Price = 11.49m },
                                     new MenuItem { Title = "Rustic Italian", Price = 12.49m }
                                 };
            return menu;
        }
    }
}
