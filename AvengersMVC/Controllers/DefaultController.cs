using AvengersMVC.Models.RSS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AvengersMVC.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            string html = @"https://www.ranker.com/list/avengers-trivia-facts/ranker-comics";
      
            var liste = RSSHelper.ReadList(html);
            ViewBag.List = liste;

            return View();
        }
    }
}