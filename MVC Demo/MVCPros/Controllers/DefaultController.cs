using MVCPros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPros.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            Users ur = new Users();
            ur.UserName = ur.ReturnUser(1050).UserName;
            ur.UserID = ur.ReturnUser(1050).UserID;
            ur.UserEmail = ur.ReturnUser(1050).UserEmail;
            return View(ur);
        }
    }
}