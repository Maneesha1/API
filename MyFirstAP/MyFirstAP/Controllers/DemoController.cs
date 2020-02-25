using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstAP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        // GET: api/Demo
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Demo/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Demo
        [HttpPost]
        public string Post(object value)
        {
            return "resource added";
        }

        // PUT: api/Demo/5
        [HttpPut("{id}")]
        public string Put(int id)
        {
            return "resouce updated";
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public string remove(int id)
        {
            return "resurce deleted";
        }
    }
}
