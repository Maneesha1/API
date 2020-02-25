using System;
using System.Collections.Generic;

namespace OrderService.Models
{
    public partial class Items
    {
        public Items()
        {
            Orders = new HashSet<Orders>();
        }

        public string Itemid { get; set; }
        public string Name { get; set; }
        public int? Price { get; set; }
        public int? Stock { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
