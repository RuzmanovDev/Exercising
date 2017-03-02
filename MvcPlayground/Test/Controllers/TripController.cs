﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controllers
{
    public class TripController : Controller
    {
        public ActionResult TripDetails()
        {
            return View();
        }

        public ActionResult RecentTrips()
        {
            // get from db pass it
            return PartialView("_RecentTrips");
        }
    }
}