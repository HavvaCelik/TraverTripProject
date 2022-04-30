using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TraverTripProject.Models.Class;

namespace TraverTripProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context DB = new Context();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Admin admin )
        {
            var LoginInformation = DB.Admins.FirstOrDefault(t0 => t0.User == admin.User && t0.Password == admin.Password);
            if(LoginInformation != null)
            {
                FormsAuthentication.SetAuthCookie(LoginInformation.User, false);
                Session["User"] = LoginInformation.User.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");
        }
    }
}