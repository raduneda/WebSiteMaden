#region

using System.Web.Mvc;
using BL;
using WebSite.Models;

#endregion

namespace WebSite.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly PhotoManager _photoManager;

        public PortfolioController() : this(null)
        {
        }

        public PortfolioController( PhotoManager photoManager )
        {
            _photoManager = photoManager ?? new PhotoManager();
        }

        // GET: Portfolio
        public ActionResult Index()
        {
            PortfolioViewModel viewModel = new PortfolioViewModel
            {
                PhotoList = _photoManager.GetPortfolioImages(PhotoManager.PortfolioImageType.All)
            };

            return View("~/Views/Portfolio/Portfolio.cshtml", viewModel);
        }

        public ActionResult Test()
        {
            PortfolioViewModel viewModel = new PortfolioViewModel
            {
                PhotoList = _photoManager.GetPortfolioImages(PhotoManager.PortfolioImageType.All)
            };

            return View("~/Views/Portfolio/PhotoListView.cshtml", viewModel);
        }
    }
}