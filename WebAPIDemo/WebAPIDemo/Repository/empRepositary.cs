using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo.Models;

namespace WebAPIDemo.Repository
{
    public class empRepositary
    {
        //get all employess
        public List<Emp> GetAll()
        {
          using (PracticeContext db = new PracticeContext())
         {
             return db.Emp.ToList();
        }
        }
        public Emp GetById(string EmpNo)
        {
            using (PracticeContext db = new PracticeContext())
            {
                return db.Emp.Find(EmpNo);
            }
        }
        public void Add(Emp item)
        {
            using (PracticeContext db = new PracticeContext())
            {
               
                    //Emp e = db.Emp.Find(item);
                    db.Emp.Add(item);
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
