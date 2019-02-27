using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FaveTunes.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About() 
        {
            ViewBag.Message = "What is FaveTunes?";

            return View(); // return to About.cshtml (Home\View\About) 
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "TouchPoint International Sdn Bhd";

            return View();
        }
    }
}