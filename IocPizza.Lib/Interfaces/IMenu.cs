namespace IocPizza.Lib
{
    using System.Collections.Generic;

    public interface IMenu
    {
        IEnumerable<IMenuItem> MenuItems { get; set; }
    }
}