using MVC_Pro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Pro.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult getUser()
        {
            Users ur = new Users();
            ViewBag.ur = ur.ReturnUsers();
            return View();
        }
    }
}