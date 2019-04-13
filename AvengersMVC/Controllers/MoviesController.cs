using AvengersMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AvengersMVC.Controllers
{
    public class MoviesController : Controller
    {
        AvengersContext db = new AvengersContext();

        // GET: Movies
        public ActionResult Index()
        {
        

            ViewBag.Yorum = db.Comments.OrderByDescending(x=>x.CmdDate).ToList();
      
            return View(db.Movies.ToList());
        }

        public ActionResult Yorum(int id)
        {
            ViewBag.ID = id;
            return View();
        }


        [HttpPost]
        public ActionResult Yorum(int id,string comment)
        {
            Comment c = new Comment();
            c.Movies = db.Movies.Find(id);
            c.Description = comment;
            c.UserId = (int)Session["id"];
            db.Comments.Add(c);
            db.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }
    }
}