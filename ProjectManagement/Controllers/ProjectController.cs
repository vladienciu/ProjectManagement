using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectManagement.Models;

namespace ProjectManagement.Controllers
{
    public class ProjectController : Controller
    {
        public ActionResult DoAnAction()
        {
            return Content("Hello world!");
        }

        public ActionResult HelloUser(string alpha)
        {
            var Name = Server.HtmlEncode(alpha);
            return Content("Hello: ", Name);
        }

    }
}