﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSite.Controllers
{
    public class PricingController : Controller
    {
        // GET: Pages
        public ActionResult Index()
        {
            return View("~/Views/Pricing/Pricing.cshtml");
        }
    }
}