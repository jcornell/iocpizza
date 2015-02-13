using System.Web.Mvc;

namespace IocPizza.Web.Controllers
{
    using System;
    using System.Collections.Generic;

    using IocPizza.Lib;

    public class PizzeriaController : Controller
    {
        private readonly IMenuFactory _menuFactory;

        public PizzeriaController(IMenuFactory menuFactory)
        {
            _menuFactory = menuFactory;
            if (_menuFactory == null)
            {
                throw new Exception("Menu was null for Pizzeria controller");
            }
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Menu()
        {   
            ViewBag.MenuItems = GetMenuItems();
            return View();
        }

        private IEnumerable<IMenuItem> GetMenuItems()
        {
            return _menuFactory.CreateMenu().MenuItems;
        }

    }
}
