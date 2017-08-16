using BusinessLayerPro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPro.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            Users ur = new Users();
            ur.GetUsers(1050);
            return View(ur);
        }
    }
}