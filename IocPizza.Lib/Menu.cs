namespace IocPizza.Lib
{
    using System.Collections.Generic;

    public class Menu : IMenu
    {
        public IEnumerable<IMenuItem> MenuItems { get; set; }
    }
}