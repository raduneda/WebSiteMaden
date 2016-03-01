using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AboutUs()
        {
            throw new NotImplementedException();
        }

        public ActionResult Services()
        {
            throw new NotImplementedException();
        }

        public ActionResult Portfolio()
        {
            throw new NotImplementedException();
        }

        public ActionResult BlogItem()
        {
            throw new NotImplementedException();
        }

        public ActionResult FourOFour()
        {
            throw new NotImplementedException();
        }

        public ActionResult Shortcodes()
        {
            throw new NotImplementedException();
        }

        public ActionResult Pricing()
        {
            throw new NotImplementedException();
        }

        public ActionResult Blog()
        {
            throw new NotImplementedException();
        }

    }
}