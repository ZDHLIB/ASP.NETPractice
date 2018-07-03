using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace OdeToFoodMVC.Controllers {
    public class CuisineController : Controller {

        public ActionResult Search(string name = "Chinese") {
            var message = Server.HtmlEncode(name);
            return Content(message);
            //return RedirectPermanent("http:microsoft.com");
            //return RedirectToAction("Index", "Home", new { name = name });
            //return RedirectToRoute("Default", new { controller = "Home", action = "About" });
            //return File(Server.MapPath("~/Content/site.css"), "text/css");
            //return Json(new { Message = message, Name = "Zac" }, JsonRequestBehavior.AllowGet);
        }
    }
}