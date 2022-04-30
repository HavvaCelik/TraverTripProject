using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TraverTripProject.Models.Class;

namespace TraverTripProject.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        BlogCommand blogCommand = new BlogCommand();
        Context db = new Context();
        public ActionResult Index()
        {
            // var blog = db.Blogs.ToList();
            blogCommand.item1 = db.Blogs.ToList();
            blogCommand.item3 = db.Blogs.Take(3);
            return View(blogCommand);
        }

        public ActionResult BlogDetail(int id)
        {
            
            blogCommand.item1 = db.Blogs.Where(t0 => t0.Id == id).ToList();
            blogCommand.item2 = db.Commands.Where(t0 => t0.Blogid == id).ToList();

            return View(blogCommand);
        }
        [HttpGet]
        public PartialViewResult Comment(int id)
        {
            ViewBag.value = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Comment(Command command)
        {
            db.Commands.Add(command);
            db.SaveChanges();
            return PartialView();
        }
    }
}