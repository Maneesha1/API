using System;
using System.Collections.Generic;

namespace WebAPIDemo.Models
{
    public partial class Project
    {
        public string Pid { get; set; }
        public string Pname { get; set; }
        public DateTime? Sdate { get; set; }
        public DateTime? Edate { get; set; }
    }
}
