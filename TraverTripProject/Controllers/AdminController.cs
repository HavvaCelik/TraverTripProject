using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TraverTripProject.Models.Class;

namespace TraverTripProject.Controllers
{
    public class AdminController : Controller
    {
        Context DB = new Context();
        // GET: Admin
        [Authorize]
        public ActionResult Index()
        {
            var result = DB.Blogs.ToList();
            return View(result);
        }

        [HttpGet]
        public ActionResult NewBlog()
        {
            //httpget ile sayfa yüklendiğinde bize geri dönsün boş hali
            return View();
        }

        [HttpPost]
        public ActionResult NewBlog(Blog p)
        {
            DB.Blogs.Add(p);
            DB.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BlogDelete( int id)
        {
            var blogdelete = DB.Blogs.Find(id);
            DB.Blogs.Remove(blogdelete);
            DB.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BlogBring(int id)
        {
            var blogbring = DB.Blogs.Find(id);
            return View("BlogBring", blogbring);

        }

        public ActionResult BlogUpdate(Blog blog)
        {
            var blogUpdate = DB.Blogs.Find(blog.Id);
            blogUpdate.Description = blog.Description;
            blogUpdate.Title = blog.Title;
            blogUpdate.Date = blog.Date;
            blogUpdate.BlogImg = blog.BlogImg;
            DB.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult CommendList()
        {
            var command = DB.Commands.ToList();
            return View(command);
        }

        public ActionResult CommandDelete(int id)
        {
            var commanddelete = DB.Commands.Find(id);
            DB.Commands.Remove(commanddelete);
            DB.SaveChanges();
            return RedirectToAction("CommendList");
        }


        public ActionResult CommandBring(int id) 
        {
            var commandbring = DB.Commands.Find(id);
            return View("CommandBring", commandbring);
        }

        public ActionResult CommandUpdate(Command command)
        {
            var commandUpdate = DB.Commands.Find(command.ID);
            commandUpdate.UserName = command.UserName;
            commandUpdate.Email = command.Email;
            commandUpdate.Commands = command.Commands;
            DB.SaveChanges();
            return RedirectToAction("CommendList");

        }

        

    }
}