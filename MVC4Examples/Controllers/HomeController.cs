using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC4Examples.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            //return "The value of id = " + id + " and Name = " + name;

            ViewBag.Countries = new List<string>() {
                "India",
                "USA",
                "UK",
                "Canada"
            };

            return View();
        }

    }
}
