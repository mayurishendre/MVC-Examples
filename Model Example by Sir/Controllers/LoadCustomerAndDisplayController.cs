using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Model_Example_by_Sir.Models;                 //....step3 add namespace from model

namespace Model_Example_by_Sir.Controllers
{
    public class LoadCustomerAndDisplayController : Controller
    {
        // GET: LoadCustomerAndDisplay
        public ActionResult Index()
        {
            //....step4 Create obj of Customer class and pass the data
            Customer objcustomer = new Customer();

            objcustomer.ID = 1001;
            objcustomer.CustomerCode = "C-1001";
            objcustomer.Amount = 1500.52;

            return View(objcustomer);
        }
    }
}