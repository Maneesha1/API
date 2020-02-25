using System;
using System.Collections.Generic;

namespace WebAPIDemo.Models
{
    public partial class Emp
    {
        public int EmpNo { get; set; }
        public string EmpFname { get; set; }
        public string EmpLname { get; set; }
        public string DeptNo { get; set; }

        public virtual Dep DeptNoNavigation { get; set; }
    }
}
