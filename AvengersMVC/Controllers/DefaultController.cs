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

            string url2 = "https://www.marvel.com/podcasts/10/this_week_in_marvel/rss";


         // string url = "https://www.marvel.com/podcasts/10/this_week_in_marvel/rss";
            ViewBag.List = RSSHelper.ReadList(url2);

            return View();
        }
    }
}