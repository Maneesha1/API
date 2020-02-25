using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebAPIDemo.Controllers;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIDemoController : ControllerBase
    {
        PracticeContext db = new PracticeContext();
        [HttpGet]//get all project records
        public List<Product> GetAll()
        {
            return db.Product.ToList();
        }
        [HttpGet("{id}")]//get project by id
        [Route("GetById /{id}")]
        public Product GetById(int id)
        {
            return db.Product.SingleOrDefault(p => p.Id == id);
        }
        [HttpGet("{name}")]
            [Route("GetByname /{name}")]
        public Product GetByName(string name)
        {
            return db.Product.SingleOrDefault(p => p.Name == name);
        }
        [HttpPost]
        [Route("AddProduct")]
        public void Add(Product item)
        {
            db.Product.Add(item);
            db.SaveChanges();
        }
        [HttpDelete]
        [Route("Delete/{Id}")]
        public void Delete(string Id)
        {
            Product o = db.Product.Find(Id);
            db.Remove(o);
            db.SaveChanges();
        }
        [HttpPut]
        [Route("Update/{Id}")]
        public void Update(string Id)
        {

            Product o = db.Product.Find(Id);
            o.Stock = 7;
            db.Product.Update(o);
            db.SaveChanges();
        }


    }
}