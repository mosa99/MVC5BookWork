using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UrlsAndRoutes.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            
            //string test = Request.Url.ToString();
            ViewBag.Controller = "Index";
            ViewBag.Action = "List";
            return View("ActionName");
        }
	}
}