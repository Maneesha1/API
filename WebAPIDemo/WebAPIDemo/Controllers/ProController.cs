using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIDemo.Models;
using WebAPIDemo.Repository;

namespace WebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProController : ControllerBase
    {
        Department repo = new Department();
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(repo.GetAll());
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public IActionResult GetById(string DepNo)
        {
            return Ok(repo.GetById(DepNo)); //Ok();
        }
        [HttpPut]
        [Route("Add")]
        public IActionResult Add(Dep item)
        {
            repo.Add(item);
            return Ok();
        }
        [HttpPut]
        [Route("Update")]
        public IActionResult Update(Dep item)
        {
            //repo.Update(item);
            return Ok();
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int DepNo)
        {
            repo.Delete(DepNo);
            return Ok("record deleted");
        }
    
}
}