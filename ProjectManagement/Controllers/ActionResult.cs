using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManagement.Controllers
{
        public class ActionResultController : Controller
        {
            public ActionResult RedirectPermanent()
            {
                return Content("This message is sent from the Index action!”;");
            }

            public ActionResult RedirectToActionInTheSameController()
            {
                return RedirectToAction("Index");
            }

            public ActionResult RedirectToActionInHomeController()
            {
                return RedirectToAction("Index");
            }

            public ActionResult RedirectToRoute()
            {
                return RedirectToRoute("About");
            }

            public ActionResult ReturnFile()
            {
                return Content("Site.css");
            }

        }
    }