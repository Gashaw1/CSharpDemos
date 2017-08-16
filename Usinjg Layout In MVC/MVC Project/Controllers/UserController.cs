using BusinessLayerPro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project.Controllers
{
    public class UserController : Controller
    {
        // GET: User

        //[HttpGet]
        //public ActionResult Index()
        //{
        //    Users user = new Users();
        //    user.GetUsers(1050);
        //    return View(user);
        //}

        [HttpGet]

        public ActionResult Index()
        {
            Users user = new Users();
            List<Users> users = user.GetUsers();
            return View(users.ToList());
        }
        //return the data to be update
        [HttpGet]
        public ActionResult Edit(Int32 id)
        {
            Users user = new Users();
            //retrun single from the collection 
            Users us = user.GetUsers().FirstOrDefault(emp => emp.UserID == id);
            return View(us);
        }
        //To perform update
        [HttpPost]
        public ActionResult Edit(FormCollection formCollection)
        {
            Users user = new Users();
            user.UserID = Convert.ToInt32(formCollection["UserID"]);
            user.UserName = formCollection["UserName"];
            user.UserEmail = formCollection["UserEmail"];
            user.UserPassword = formCollection["UserPassword"];
            bool upateResult = user.UpdateUser(user);

            if (upateResult == true)
            {
              return RedirectToAction("Index");
               // return View();
            }
            else
            {
                return RedirectToAction("Edit");
                // return View();
            }

        }
        //Return the view to enter the data
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        //post the form to the database
        [HttpPost]
        public ActionResult Create(FormCollection formCollection)
        {
            Users user = new Users();
            user.UserName = formCollection["UserName"];
            user.UserEmail = formCollection["UserEmail"];
            user.UserPassword = formCollection["UserPassword"];
            user.AddUser(user);

            //To redirect to the index view
            return RedirectToAction("Index");
        }
       

    }
}