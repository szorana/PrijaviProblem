using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrijaviProblem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "ПријавиПроблем++";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Контакт";

            return View();
        }
    }
}