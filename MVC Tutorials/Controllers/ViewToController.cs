using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MVC_Tutorials.Models;

namespace MVC_Tutorials.Controllers
{
    public class ViewToController : Controller
    {
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
            if (fname != null || lname != null)
            {
                Response.Write("Your Full name is= " + fname + " " + lname);
            }



            return View();
        }

        public ActionResult ModelBinding(UserModel2 model)
        {
            string message = "";

            if (ModelState.IsValid)
            {
                message = "Your Full name is= " + model.First_Name + " " + model.Last_Name;
            }
            if (model.First_Name == null && model.Last_Name == null)
            {
                message = "";
            }

            Response.Write(message);


            return View();
        }
    }
}