using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo.Models;

namespace WebAPIDemo.Repository
{
    public class Department
    {

        public List<Dep> GetAll()
        {
            using (PracticeContext db = new PracticeContext())
            {
                return db.Dep.ToList();
            }
        }
        public Dep GetById(string DepNo)
        {
            using (PracticeContext db = new PracticeContext())
            {
                return db.Dep.Find(DepNo);
            }
        }
        public void Add(Dep item1)
        {
            using (PracticeContext db = new PracticeContext())
            {

                //Emp e = db.Emp.Find(item);
                db.Dep.Add(item1);
                db.SaveChanges();
            }




        }
        public void Delete(int EmpNo)
        {
            using (PracticeContext db = new PracticeContext())
            {
                Emp e = db.Emp.Find(EmpNo);
                db.Emp.Remove(e);
                db.SaveChanges();
            }

        }
        public void Update(Emp item)
        {
            using (PracticeContext db = new PracticeContext())
            {
                //Emp e = db.Emp.Find(item);
                db.Emp.Update(item);
                db.SaveChanges();
            }

        }
    }
}
