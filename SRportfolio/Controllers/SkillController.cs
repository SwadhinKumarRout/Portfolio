using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SRportfolio.Controllers
{
    public class SkillController : Controller
    {
        // GET: Skill
        public ActionResult Skill()
        {
            ViewBag.ClientSide = "React JS";
            ViewBag.BackendSide = "Node JS";
            ViewBag.Database = "SQL Server";
            return View();
        }
    }
}