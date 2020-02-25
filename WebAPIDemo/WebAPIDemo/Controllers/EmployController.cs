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
    public class EmployController : ControllerBase
    {
        empRepositary rep = new empRepositary();
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
          return Ok(rep.GetAll());
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public IActionResult GetById(string EmpNo)
        {
            return Ok(rep.GetById(EmpNo)); //Ok();
        }
        [HttpPut]
        [Route("Add")]
        public IActionResult Add(Emp item)
        {
            rep.Add(item);
            return Ok();
        }
        [HttpPut]
        [Route("Update")]
        public IActionResult Update(Emp item)
        {
            rep.Update(item);
            return Ok();
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int EmpNo)
        {
            rep.Delete(EmpNo);
            return Ok("record deleted");
        }
    }
}