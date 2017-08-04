using BusinessLayersObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Using__Business_ObjectLayers.Controllers
{
    public class GetUserController : Controller
    {
        private Users user { get; set; }
        private List<Users> users { get; set; }
        // GET: GetUser
        //return all users
        public ActionResult Index()
        {
            user = new Users();
            users = new List<Users>(user.ReturnUsers());
            return View(users.ToList());
        }
        //retrun single user
        public ActionResult Index2()
        {
            user = new Users();
            user = user.ReturnUser(1050);
            return View(user);
        }
    }
}