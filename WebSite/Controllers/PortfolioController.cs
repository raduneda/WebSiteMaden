#region

using System;
using System.Web.Mvc;
using BL;
using TL;
using TL.Enums;
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
                PhotoList = _photoManager.GetPortfolioImages(PhotoEnum.PortfolioImageType.All),
                PhotoTypes = new[] { PhotoEnum.PortfolioImageType.Creative, PhotoEnum.PortfolioImageType.Standard }          
            };

            return View("~/Views/Portfolio/Index.cshtml", viewModel);
        }
    }
}