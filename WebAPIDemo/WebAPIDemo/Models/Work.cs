using System;
using System.Collections.Generic;

namespace WebAPIDemo.Models
{
    public partial class Work
    {
        public int? EmpNo { get; set; }
        public string ProjectNo { get; set; }
        public string Job { get; set; }
        public DateTime? EnterDate { get; set; }
    }
}
