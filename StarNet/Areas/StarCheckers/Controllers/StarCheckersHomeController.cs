using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StarNet.Areas.StarCheckers.Controllers
{
    public class StarCheckersHomeController : Controller
    {
        // GET: StarCheckers/StarCheckersHome
        public ActionResult Index()
        {
            return View();
        }
    }
}