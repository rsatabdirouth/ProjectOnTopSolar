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
        [HttpGet]
        public ActionResult SecondIndex(SecondIndexViewModel model)
        {
            Merger merger = new Merger
            {
                Address = model.EnquieryViewModel.Address,
                HomeOwner = model.PropertyViewModel.HomeOwner,
                Title = model.EnquieryViewModel.Title,
                FirstName = model.EnquieryViewModel.FirstName,
                LastName = model.EnquieryViewModel.LastName,
                City = model.EnquieryViewModel.City,
                HomePhone = model.EnquieryViewModel.HomePhone,
                WorkPhone = model.EnquieryViewModel.WorkPhone,
                Email = model.EnquieryViewModel.Email,
                PropertyType = model.PropertyViewModel.PropertyType,
                YourPostCode = model.PropertyViewModel.YourPostCode
             };

                _db.Mergers.Add(merger);
                _db.SaveChanges();
                return RedirectToAction("ThirdIndex","Third");
        }

        

    }
}