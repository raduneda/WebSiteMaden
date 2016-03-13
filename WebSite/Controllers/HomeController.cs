#region

using System.Web.Mvc;
using BL;
using WebSite.Models;

#endregion

namespace WebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly CarouselManager _carouselManager;
        private readonly PhotoManager _photoManager;

        public HomeController() : this(null,null)
        {
        }

        public HomeController( CarouselManager carouselManager, PhotoManager photoManager )
        {
            _carouselManager = carouselManager ?? new CarouselManager();
            _photoManager = photoManager ?? new PhotoManager();
        }

        public ActionResult Index()
        {
            HomeViewModel viewModel = new HomeViewModel
            {
                CarouselItems = _carouselManager.GetCarouselItems(),
                PortfolioItems = _photoManager.GetRecentImages()
            };
            return View("~/Views/Home/Index.cshtml", viewModel);
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
            return RedirectToAction("Index", "Pricing");
        }

        public ActionResult Blog()
        {
            return RedirectToAction("Index", "Blog");
        }
    }
}