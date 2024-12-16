using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Shopping.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index1(int? id, string name, double? price)
        {
            ViewData["Id"] = id;
            ViewData["Name"] = name;
            ViewData["Price"] = price;
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [ActionName("c")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View("Contact");
        }
        public ActionResult rk()
        {
            return View();
        }
        
    }
}