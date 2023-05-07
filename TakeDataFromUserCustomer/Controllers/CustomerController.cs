using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using TakeDataFromUserCustomer.Models;                 //step5

namespace TakeDataFromUserCustomer.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        //step3
        public ActionResult FillCustomer()
        {
            return View();
        }
        //step4
        //right click and add view for displaycustomer
        //also add strongly typed option to pass the obj
        public ActionResult DisplayCustomer()
        {

            //step6 create obj of customer class
            Customer obj = new Customer();

            obj.CustomerID = Convert.ToInt32(Request.Form["CustomerID"]);
            obj.CustomerCode=Request.Form["CustomerCode"];
            obj.Amount = Convert.ToSingle(Request.Form["Amount"]);

            return View(obj);    //passing object to the view

        }


    }
}