using System.Web.Mvc;

namespace IocPizza.Web.Controllers
{
    using System.Collections.Generic;

    using IocPizza.Lib;

    public class PizzeriaController : Controller
    {
        private readonly IMenu _menu;

        public PizzeriaController(IMenu menu)
        {
            _menu = menu;
        }

        public ActionResult Index()
        {
            ViewBag.MenuItems = _menu.MenuItems;
            return View();
        }

        public ActionResult Menu()
        {
            ViewBag.MenuItems = _menu.MenuItems ?? new List<MenuItem>() { new MenuItem{Title = "Sicilian", Price = 12.88m} };
            return View();
        }

    }
}
