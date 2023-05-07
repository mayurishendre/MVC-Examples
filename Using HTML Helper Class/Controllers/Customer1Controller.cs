using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Using_HTML_Helper_Class.Models;  //step3 add model class 

namespace Using_HTML_Helper_Class.Controllers 
{
    //step 2 add controller
    public class Customer1Controller : Controller
    {
        // GET: Customer1
        public ActionResult Index()
        {
            //step4
           

            return View();
        }
        public ActionResult FillCustomer()
        {
            return View();
        }
        public ActionResult DisplayCustomer()
        {
            Customer obj = new Customer();

            obj.ID = 1001;
            obj.CustomerCode = "C-101";
            obj.Amount = 5200;

            return View(obj);
        }
    }
}