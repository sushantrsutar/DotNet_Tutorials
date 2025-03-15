using Microsoft.AspNetCore.Mvc;
using WebApiDemoTQ.Models;
using WebApiDemoTQ.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiDemoTQ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeServices service;

        public EmployeeController(IEmployeeServices services) //controller have dependency with service
        { 
            this.service = services;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        [Route("GetEmployees")]
        public IActionResult Get()
        {
            try
            {
                var model=service.GetEmployees();
                if (model != null)
                {
                    return new OkObjectResult(model);//return json object
                }
                else {
                    return StatusCode(StatusCodes.Status204NoContent);
                }
            }
            catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // GET api/<EmployeeController>/5
        [HttpGet]
        [Route("GetEmployee/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var model = service.GetEmployee(id);
                if (model != null)
                {
                    return new OkObjectResult(model);//return json object
                }
                else
                {
                    return StatusCode(StatusCodes.Status204NoContent);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // POST api/<EmployeeController>
        [HttpPost]
        [Route("AddEmployee")]
        public IActionResult Post([FromBody] Employee emp)
        {
            try
            {
                int result = service.AddEmployee(emp);
                if (result>= 1)
                {
                    return StatusCode(StatusCodes.Status201Created);
                }
                else
                {
                    return StatusCode(StatusCodes.Status400BadRequest);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // PUT api/<EmployeeController>/5
        [HttpPut]
        [Route("UpdateEmployee/")]
        public IActionResult Put([FromBody] Employee emp)
        {
            try
            {
                int result = service.UpdateEmployee(emp);
                if (result >= 1)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status400BadRequest);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete]
        [Route("DeleteEmployee/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                int result = service.DeleteEmployee(id);
                if (result >= 1)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status400BadRequest);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }
    }
}
