using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page. I've added a change. Also this needed fixed";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page. This fix might not actually be done yet.";

            return View();
        }
    }
}
