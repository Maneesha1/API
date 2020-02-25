using System;
using System.Collections.Generic;

namespace WebAPIDemo.Models
{
    public partial class Orders
    {
        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public DateTime? Orderdate { get; set; }
        public DateTime? Shippeddate { get; set; }
        public decimal? Freight { get; set; }
        public string Shipname { get; set; }
        public string Shipaddres { get; set; }
        public int? Quantity { get; set; }
    }
}
