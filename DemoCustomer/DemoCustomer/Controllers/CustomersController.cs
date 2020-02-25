using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DemoCustomer.Controllers;
using DemoCustomer.Models;

namespace DemoCustomer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        CustomerContext db = new CustomerContext();
        // GET: api/Customers
        [HttpGet]
        public List<Ctable> GetAll()
        {
            return db.Ctable.ToList();
        }
        [HttpGet]
        [Route("GetById/{Cid}")]
        public Ctable GetById(int Cid)
        {
            return db.Ctable.Find(Cid);
        }

        [HttpGet]
        [Route("GetBycity/{city}")]
        public Ctable GetBycity(string city)
        {
            return db.Ctable.SingleOrDefault(p => p.City == city );
                ;
        }
        [HttpPost]
        [Route("Add")]
        public void Add(Ctable item)
        {
            db.Ctable.Add(item);
            db.SaveChanges();
        }
        [HttpPut]
        [Route("Update")]
        public void Update(Ctable C)
        {

           // Ctable o = db.Ctable.Find(Cid);
            //o.Cname = "manu";
            db.Ctable.Update(C);
            db.SaveChanges();
        }


    }
}