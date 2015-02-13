using System.Web.Mvc;

namespace IocPizza.Web.Controllers
{
    using IocPizza.Lib;

    public class PizzariaController : Controller
    {
        private readonly IMenu _menu;

        public PizzariaController(IMenu menu)
        {
            _menu = menu;
        }

        public ActionResult Index()
        {
            ViewBag.MenuItems = _menu.MenuItems;
            return View();
        }

        public ActionResult Orders()
        {
            
            return View();
        }

    }
}
