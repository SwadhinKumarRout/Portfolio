using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Swadhinportfolio.Controllers
{
    public class ExperienceController : Controller
    {
        // GET: Experience
        public ActionResult Experience()
        {
            ViewBag.Experience = "React JS";
            return View();
        }
    }
}