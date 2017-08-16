using BusinessLayerPro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult User()
        {   
            Users user = new Users();
            user = user.GetUsers(1050);
            return View(user);
        }
        // GET: Update
        [HttpPost]
        public ActionResult Create(FormCollection form) 
        {
            Users user = new Users();
            user.UserName = form["UserName"];
            user.UserEmail = form["UserPassword"];
            user.UserPassword = form["UserPassword"];
            user.UpdateUserInCach(user);

            return RedirectToAction("Index");
            // View(Index);
        }
        //[HttpPost]
        public ActionResult UpdateDataSet()
        {
            Users user = new Users();

            List<Users> users = new List<Users>(user.GetUsersDataset());

            return View(users.ToList());
        }
        // GET: All
        [HttpGet]
        public ActionResult ReturnAll()
        {
            Users user = new Users();

            List<Users> users = new List<Users>(user.GetUsers());

            return View(users.ToList());
        }
        // GET: Add
        [HttpPut]
        public ActionResult AddNewUser()
        {
            Users ur = new Users();
            //ur.UserName = "newname";
            //ur.UserEmail = "new Email";
            //ur.UserPassword = "pass";
            //ur.InsertData(ur);
            return View(ur);
        }
        // GET: UpdateDataBaseFromCach
        [HttpPost]
        public ActionResult UpdateDataBase()
        {
            Users ur = new Users();
            ur.UpdateDataBaseFromCached();
            return View(ur);
        }
    }
}