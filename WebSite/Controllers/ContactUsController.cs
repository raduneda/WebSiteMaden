﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSite.Controllers
{
    public class ContactUsController : Controller
    {
        // GET: ContactUs
        public ActionResult Index()
        {
            return View("~/Views/ContactUs/ContactUs.cshtml");
        }

        public ActionResult SendMail()
        {
            throw new NotImplementedException();
        }
    }
}