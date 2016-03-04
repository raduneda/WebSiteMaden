using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSite.Controllers
{
    public class BlogController : Controller
    {
        // GET: AboutUs
        public ActionResult Index()
        {
            return View("~/Views/Blog/Blog.cshtml");
        }

        public ActionResult BlogItemComments()
        {
            throw new NotImplementedException();
        }

        public ActionResult BlogItem()
        {
            throw new NotImplementedException();
        }
    }
}