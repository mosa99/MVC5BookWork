using System.Web.Mvc;
using System;

namespace WorkingWithRazor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string[] names = { "Apple", "Orange", "Pear" };
            return View(names);
        }

        [ChildActionOnly]
        public ActionResult Time()
        {
            return PartialView(DateTime.Now);
        }
    }
}