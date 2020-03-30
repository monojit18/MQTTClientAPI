using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using TestNetCoreAPI.Models;

namespace TestNetCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(TNCResponseModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(TNCResponseModel), StatusCodes.Status404NotFound)]
        public ActionResult<TNCResponseModel> Get(int id)
        {
            if (id <= 5)
            {

                return Ok(new TNCResponseModel()
                {
                    Message = "All OK"

                });

            }

            return NotFound();

        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {

            
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
