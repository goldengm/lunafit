using Lunafit.Bc.Interface;
using Lunafit.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lunafit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly IToDoBc _toDoBc;

        public ToDoController(IToDoBc toDoBc)
        {
            _toDoBc = toDoBc;
        }
        // GET: api/<ToDoController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            { 
                var result = new ResponseModel
                {
                    Data = await _toDoBc.GetAsync()
                };
                return Ok(result);
            }
            catch (Exception ex)
            {
                //We can add anothe global method here to log the exceptions in the database or cloud watch.
                return StatusCode(500);
            }
            
        }

        // GET api/<ToDoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ToDoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ToDoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ToDoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
