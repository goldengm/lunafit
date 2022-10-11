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
    public class ToDoDbController : ControllerBase
    {
        private readonly IToDoBc _toDoBc;
        public ToDoDbController(IToDoBc toDoBc)
        {
            _toDoBc = toDoBc;
        }
        // GET: api/<ToDoDbController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = new ResponseModel
                {
                    Data = await _toDoBc.GetDbAsync()
                };
                return Ok(result);
            }
            catch (Exception ex)
            {
                //We can add anothe global method here to log the exceptions in the database or cloud watch.
                return StatusCode(500);
            }
        }

        // GET api/<ToDoDbController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var result = new ResponseModel
                {
                    Data = await _toDoBc.GetByIdDbAsync(id)
                };
                return Ok(result);
            }
            catch (Exception ex)
            {
                //We can add anothe global method here to log the exceptions in the database or cloud watch.
                return StatusCode(500);
            }
        }
        
    }
}
