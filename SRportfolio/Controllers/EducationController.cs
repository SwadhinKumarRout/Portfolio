using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SRportfolio.Controllers
{
    public class EducationController : Controller
    {
        // GET: Education
        public ActionResult Education()
        {
            ViewBag.SchoolName = "ASM";
            ViewBag.SchoolPercentage = 50;
            ViewBag.CollegeName = "Science College";
            ViewBag.CollegePercentage = 62;
            ViewBag.CollegeStream = "Science";

            return View();
        }
    }
}