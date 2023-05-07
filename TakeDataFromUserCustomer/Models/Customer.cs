using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TakeDataFromUserCustomer.Models
{
    public class Customer
    {
        //step1

        public int CustomerID { get; set; }
        public string CustomerCode { get; set; }
        public double Amount { get; set; }
    }
}