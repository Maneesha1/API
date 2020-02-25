using System;
using System.Collections.Generic;

namespace WebAPIDemo.Models
{
    public partial class Dep
    {
        public Dep()
        {
            Emp = new HashSet<Emp>();
        }

        public string DeptNo { get; set; }
        public string DeptName { get; set; }
        public string Location { get; set; }

        public virtual ICollection<Emp> Emp { get; set; }
    }
}
