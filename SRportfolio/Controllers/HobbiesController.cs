using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SRportfolio.Controllers
{
    public class HobbiesController : Controller
    {
        // GET: Hobbies
        public ActionResult Hobbies()
        {

            string[] hobbies = new string[2]
            {
                "Singing", "Travelling"
            };
            ViewBag.Hobbies = hobbies;
            return View();
        }
    }
}