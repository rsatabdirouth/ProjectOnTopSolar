using ProjectOnTopSolar.Models;
using ProjectOnTopSolar.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectOnTopSolar.Controllers
{

    public class HomeController : Controller
    {
        private TopSolarEntities _db = new TopSolarEntities();
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            PropertyViewModel model = new PropertyViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(PropertyViewModel model)
        {
            Merger merger = new Merger
            {
                PropertyType = model.PropertyType,
                HomeOwner = model.HomeOwner,
                YourPostCode = model.YourPostCode
            };
            _db.Mergers.Add(merger);
            _db.SaveChanges();
            return RedirectToAction("SecondIndex", "Second");
        }


       
    }
}