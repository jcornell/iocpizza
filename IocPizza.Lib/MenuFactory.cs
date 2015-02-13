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
                                     new MenuItem { Title = "Neapolitan", Price = 11.34m }
                                 };
            return menu;
        }
    }
}
