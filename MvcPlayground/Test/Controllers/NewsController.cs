using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Models;
using Test.Web.Models;

namespace Test.Controllers
{
    public class NewsController : Controller
    {
        private readonly IService service;

        public NewsController(IService service)
        {
            this.service = service;
        }

        public ActionResult Sport()
        {
            var model = new NewsViewModel()
            {
                Title = "Arsenal",
            };

            return this.View(model);
        }
    }
}