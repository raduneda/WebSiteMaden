#region

using System;
using System.Web.Mvc;

#endregion

namespace WebSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ContactUs()
        {
            return RedirectToAction("Index", "ContactUs");
        }

        public ActionResult AboutUs()
        {
            return RedirectToAction("Index", "AboutUs");
        }

        public ActionResult Services()
        {
            return RedirectToAction("Index", "Services");
        }

        public ActionResult BlogItem()
        {
            return RedirectToAction("BlogItem", "Blog");
        }

        public ActionResult FourOFour()
        {
            return View("Error");
        }

        public ActionResult Pricing()
        {
            return RedirectToAction("Index","Pricing");
        }

        public ActionResult Blog()
        {
            return RedirectToAction("Index", "Blog");
        }
    }
}