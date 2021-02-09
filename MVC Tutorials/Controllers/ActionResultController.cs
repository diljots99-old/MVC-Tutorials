using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Tutorials.Models;


namespace MVC_Tutorials.Controllers
{
    public class ActionResultController : Controller
    {
        // GET: ActionResult
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewExample()
        {
            return View();
        }
        
        public ActionResult PartialViewExample()
        {
            return PartialView("_PartialViewExample");
        }
        public ActionResult RedirectExample()
        {
            return Redirect("Index");
        }

        public ActionResult JsonExample()
        {
            var user = new User()
            {
                Id=1,
                First_Name="Diljot",
                Last_Name="Singh",
                Age=21
            };
            return Json(user, JsonRequestBehavior.AllowGet); 
        }

        public ActionResult ContentExample()
        {
            return Content("<script>alert('This is Example of Content action Result');</script>"); 
        }
        public ActionResult FileExample()
        {
            string path = Server.MapPath("~/Web.config");
            return File(path, "text/html");
        }
        public ActionResult RedirectToActionExample()
        {
            return RedirectToAction("Index","Home");
        }




    }
}