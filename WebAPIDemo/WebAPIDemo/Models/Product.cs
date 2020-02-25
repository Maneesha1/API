using System;
using System.Collections.Generic;

namespace WebAPIDemo.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Price { get; set; }
        public int? Stock { get; set; }
    }
}
