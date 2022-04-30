using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TraverTripProject.Models.Class;

namespace TraverTripProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        Context DB = new Context();
        public ActionResult Index()
        {
            var result = DB.Blogs.Take(8).ToList();
            return View(result);
        }

        public ActionResult About()
        {
            return View();
        }

        public PartialViewResult Partial1()
        {
            var result = DB.Blogs.OrderByDescending(t0 => t0.Id).Take(2).ToList();
            return PartialView(result);
        }

        public PartialViewResult Partial2()
        {
            var result = DB.Blogs.Where(t0 => t0.Id==4).ToList();
            return PartialView(result);
        }

        public PartialViewResult Partial3()
        {
            var result = DB.Blogs.Take(10).ToList();
            return PartialView(result);
        }

        public PartialViewResult Partial4()
        {
            var result = DB.Blogs.Take(3).ToList();
            return PartialView(result);
        }

        public PartialViewResult Partial5()
        {
            var result = DB.Blogs.Take(3).OrderByDescending(t0=>t0.Id).ToList();
            return PartialView(result);
        }
    }
}