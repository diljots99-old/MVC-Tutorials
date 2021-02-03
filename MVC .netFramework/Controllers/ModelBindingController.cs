using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Tutorials.Models;

namespace MVC_Tutorials.Controllers
{
    public class ModelBindingController : Controller
    {
        // GET: ModelBinding
        public ActionResult Index(UserModel model)
            
        {
           
            return View();
        }
        public ActionResult List()
        {
            return View();
        }
    }
}