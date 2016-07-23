using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloApiWithCoreDapper.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloApiWithCoreDapper.Controllers
{
    [Route("api/[controller]")]
    public class FruitController : Controller
    {
        IFruitService _fruitService = new FruitService();
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var fruitDtoList = await _fruitService.FruitQuery();
            return new OkObjectResult(fruitDtoList);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
