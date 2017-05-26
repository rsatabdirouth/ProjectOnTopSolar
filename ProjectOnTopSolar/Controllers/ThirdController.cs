using ProjectOnTopSolar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectOnTopSolar.Controllers
{
    public class ThirdController : Controller
    {
        public TopSolarEntities _db = new TopSolarEntities();
        // GET: Third
        [HttpGet]
        public ActionResult ThirdIndex()
        { 
            return View();
        }
    }
}