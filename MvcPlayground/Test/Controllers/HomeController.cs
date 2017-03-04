using Services;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Test.Web.Models;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        private readonly IService service;

        public HomeController(IService service)
        {
            this.service = service;
        }

        public ActionResult Index(int id = 0)
        {

            return View();
        }

        public JsonResult Towns()
        {
            //Note : you can bind same list from database  
            List<City> ObjList = new List<City>()
            {

                new City {Id=1,Name="Sofia" },
                new City {Id=2,Name="Plovdiv" },
                new City {Id=3,Name="Varna" },
                new City {Id=4,Name="Burgas" },
                new City {Id=5,Name="Dehradun" },
                new City {Id=6,Name="Noida" },
                new City {Id=7,Name="New Delhi" }

        };
            return Json(ObjList, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult LoadComments(int page = 0)
        {
            var posts = this.service.GetAllData().Skip(page * 5).Take(5);

            return PartialView("AjaxTest", posts);
        }

        [HttpPost]
        public ActionResult PostComment(PostViewModel model)
        {
            if (ModelState.IsValid)
            {
                this.service.Add(model);
                return RedirectToAction(nameof(LoadComments));
            }

            return PartialView("AjaxTest", model);
        }

        public ActionResult Profiles(string username = "aad")
        {
            return Content(username);
        }

        public ActionResult TestHomePage()
        {

            return View();
        }
    }
}