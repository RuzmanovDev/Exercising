using System;
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

        [HttpPost]
        public ActionResult CreateNewTrip()
        {
            return null;
        }

        public ActionResult CreatingTrip()
        {
            return View();
        }

        //public JsonResult GetTowns(string Prefix)
        //{
        //    //Note : you can bind same list from database  
        //    List<City> ObjList = new List<City>()
        //    {

        //        new City {Id=1,Name="София" },
        //        new City {Id=2,Name="Пловдив" },
        //        new City {Id=3,Name="Семчиново" },
        //        new City {Id=4,Name="Септември" },
        //        new City {Id=5,Name="Dehradun" },
        //        new City {Id=6,Name="Noida" },
        //        new City {Id=7,Name="New Delhi" }

        //};
        //    //Searching records from list using LINQ query  
        //    var CityName = (from N in ObjList
        //                    where N.Name.StartsWith(Prefix)
        //                    select new { N.Name });
        //    return Json(CityName, JsonRequestBehavior.AllowGet);
        //}
    }
}