using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TraverTripProject.Models.Class;
namespace TraverTripProject.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context db = new Context();
        public ActionResult Index()
        {
            var aboutList = db.Abouts.ToList();
            return View(aboutList);
        }
    }
}