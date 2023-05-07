using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RouteConfig_Examples.Models;

namespace RouteConfig_Examples.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FillCustomer()
        {
            return View();
        }
        public ActionResult DisplayCustomer()
        {
            Customer obj = new Customer();

            obj.ID = Convert.ToInt32(Request.Form["CustomerID"]);
            obj.CustomerCode = Request.Form["CustomerCode"];
            obj.Amount = Convert.ToInt32(Request.Form["Amount"]);

            
            return View(obj);
        }
    }
}