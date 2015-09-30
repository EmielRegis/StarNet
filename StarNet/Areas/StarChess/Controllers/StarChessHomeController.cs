using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StarNet.Areas.StarChess.Controllers
{
    public class StarChessHomeController : Controller
    {
        // GET: StarChess/StarChessHome
        public ActionResult Index()
        {
            return View();
        }
    }
}