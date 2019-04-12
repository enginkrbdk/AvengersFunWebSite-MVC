using AvengersMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AvengersMVC.Controllers
{
    public class UserController : Controller
    {
        AvengersContext db = new AvengersContext();

        [HttpGet]
        public ActionResult Login()
        {
            if (Session["uname"] != null)
            {
                Session.Remove("uname");

            }
            return View();
        }

        [HttpPost]
        public ActionResult Login(string uname, string password)
        {
            Session["uname"] = uname;
            var user = db.Users.FirstOrDefault(x => x.UserName == uname && x.Password == password);
            if (user != null)
            {


                return RedirectToAction("Index", "Default");


            }
            else
            {
                ViewBag.Error = "User is not found! Please Register";

               // RedirectToAction("Default", "Index");
            }
            return View();
        }



        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(string fname, string uname, string pass)
        {
            User u = new User();
            u.FullName = fname;
            u.UserName = uname;
            u.Password = pass;

            if (db.Users.FirstOrDefault(x => x.UserName == uname) != null)
            {
                ViewBag.Er = "Username already has taken ☺";
            }
            else { db.Users.Add(u); }


            if (db.SaveChanges() > 0)
            {

                ViewBag.Succ = "Succesfully Registered ☻";
                return View("Login");
            }


            return View();

        }
   


    }
}