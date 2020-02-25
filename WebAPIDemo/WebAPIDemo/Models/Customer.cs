using System;
using System.Collections.Generic;

namespace WebAPIDemo.Models
{
    public partial class Customer
    {
        public string Customerid { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Adrs { get; set; }
        public string Town { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
    }
}
