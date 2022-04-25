using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_WebApp.Controllers
{
    public class LogoutController : Controller
    {
        // GET: Logout
        public ActionResult Logout()
        {
            return RedirectToAction("Create", "Login");
        }
    }
}