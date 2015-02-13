using System.Web.Mvc;

namespace IocPizza.Web.Controllers
{
    using System;

    using IocPizza.Lib;

    public class PizzeriaController : Controller
    {
        private readonly IMenu _menu;

        public PizzeriaController(IMenu menu)
        {
            _menu = menu;
            if (_menu == null)
            {
                throw new Exception("Menu was null for Pizzeria controller");
            }
        }

        public ActionResult Index()
        {
            ViewBag.MenuItems = _menu.MenuItems;
            return View();
        }

        public ActionResult Menu()
        {
            if (_menu.MenuItems == null)
            {
                throw new Exception("Menu.MenuItems was null for Pizzeria controller");
            }
            ViewBag.MenuItems = _menu.MenuItems;
            return View();
        }

    }
}
