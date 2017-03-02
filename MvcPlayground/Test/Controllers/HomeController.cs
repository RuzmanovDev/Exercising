using Services;
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