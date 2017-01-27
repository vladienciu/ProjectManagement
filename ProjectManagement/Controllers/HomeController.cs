using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ProjectManagement.Controllers
{
    public class HomeController : Controller
    {
        public double Average()
        {
            var list = new List<int> { 1, 3, 5, 7, 9 };
            int sum = 0;
            foreach (int x in list)
                sum += x;
            return sum / list.Count;
        }

        public ActionResult HelloWorld()
        {
            return Content(".. Hello World ! ..");
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RedirectToRoute()
        {
            return Content("");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Author = "Vlad Ienciu";

            var model = new Models.AboutModel();
            model.Message = "This is a test";
            model.Author = "Vlad";
            return View(model);

        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}