using AvengersMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AvengersMVC.Controllers
{
    public class CharacterController : Controller
    {
        AvengersContext db = new AvengersContext();
        public ActionResult Index()
        {
            List<Character> liste = (from c in db.Characters
                                 orderby c.Age descending
                                 select c)
                                 .ToList();
      
            return View(liste);
        }

        public ActionResult Detail(int id)
        {
            Character c = db.Characters.Find(id);

            return View(c);
        }
    }
}