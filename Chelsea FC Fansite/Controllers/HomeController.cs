﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chelsea_FC_Fansite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult News()
        {
            return View();
        }
        public ActionResult Updates()
        {
            return View();
        }
        public ActionResult Gallery()
        {
            return View();
        }
    }
}
