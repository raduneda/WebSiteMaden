#region

using System.Web.Mvc;

#endregion

namespace WebSite.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        public ActionResult Index()
        {
           return View("~/Views/Portfolio/Portfolio.cshtml");
        }
    }
}