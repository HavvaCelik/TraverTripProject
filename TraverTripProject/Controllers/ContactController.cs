using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TraverTripProject.Models.Class;

namespace TraverTripProject.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        Context DB = new Context();

        
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Index(Contact contact)
        {
            DB.Contacts.Add(contact);
            DB.SaveChanges();
            return RedirectToAction("Index");
        }
        

    }
}