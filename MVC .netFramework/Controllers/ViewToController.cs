using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.netFramework.Models;

namespace MVC.netFramework.Controllers
{
    public class ViewToController : Controller
    {
        // GET: FormCollection
        public ActionResult Index()
        {

            return View();
        }


        public ActionResult FormCollection()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FormCollection(FormCollection data)
        {
            string fname = data["fname_name"];
            string lname = data["lname_name"];
            Response.Write("Your Full name is= " + fname + " " + lname);
            return View();
        }

     
        public ActionResult RequestObject()
        {
            string fname = Request["fname_name"];
            string lname = Request["lname_name"];
            
            Response.Write("Your Full name is= " + fname + " " + lname);

            return View();
        }

        public ActionResult QueryString()
        {
            string fname = Request.QueryString["first_name"];
            string lname = Request.QueryString["last_name"];
            if (fname != null|| lname != null) { 
                Response.Write("Your Full name is= " + fname + " " + lname);
                     }


            return View();
        }

        public ActionResult ModelBinding(UserModel model)
        {
            string message = "";

            if (ModelState.IsValid)
            {
                message = "Your Full name is= " + model.first_name + " " + model.last_name;
            }
            if (model.first_name == null && model.last_name == null)
            {
                message = "";
            }

            Response.Write(message);
          

            return View();
        }
    }
}