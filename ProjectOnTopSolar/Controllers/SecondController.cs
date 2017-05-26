using ProjectOnTopSolar.Models;
using ProjectOnTopSolar.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectOnTopSolar.Controllers
{
    public class SecondController : Controller
    {
        private TopSolarEntities _db = new TopSolarEntities();
        // GET: Second
        [HttpGet]
        public ActionResult SecondIndex()
        {
            SecondIndexViewModel model = new SecondIndexViewModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult SecondIndex(EnquieryViewModel model)
        {
            Merger merger = new Merger
            {
                Address = model.Address,               
                Title = model.Title,
                FirstName = model.FirstName,
                LastName = model.LastName,
                City = model.City,
                HomePhone = model.HomePhone,
                WorkPhone = model.WorkPhone,
                Email = model.Email               
             };

                _db.Mergers.Add(merger);
                _db.SaveChanges();
                return RedirectToAction("ThirdIndex","Third");
        }

        

    }
}