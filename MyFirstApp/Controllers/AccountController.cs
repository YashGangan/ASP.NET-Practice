using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstApp.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "manager")
                return RedirectToAction("Dasboard", "Admin");
            else
                return RedirectToAction("InvalidLogin");
        }
        public ActionResult InvalidLogin()
        {
            return View();
        }
    }
}