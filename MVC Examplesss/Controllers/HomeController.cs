﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Examplesss.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()     //Action Result
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult HelloWorld()
        {

            ViewData["CurrentTime"] = DateTime.Now.ToString();
            return View();
        }
    }
}