using System;
using System.Collections.Generic;

namespace WebAPIDemo.Models
{
    public partial class Product1
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public int? Price { get; set; }
        public int? Stock { get; set; }
    }
}
