using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Some information about me.";

            return View();
        }

        public ActionResult Project()
        {
            ViewBag.Message = "Some projects I have worked on.";

            return View();
        }

        public ActionResult SkillSet()
        {
            ViewBag.Message = "Skills I have gathered over the years.";
            
            return View();
        }

        public ActionResult Employment()
        {
            ViewBag.Message = "Employment History";
            
            return View();
        }
    }
}