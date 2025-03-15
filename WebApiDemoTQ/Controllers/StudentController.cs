using Microsoft.AspNetCore.Mvc;
using WebApiDemoTQ.Models;
using WebApiDemoTQ.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiDemoTQ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService studentService;

        public StudentController(IStudentService studentService) { 
            this.studentService = studentService;
        }

        // GET: api/<StudentController>
        [HttpGet]
        [Route("GetAllStudents")]
        public IActionResult Get()
        {
            try {
                var stu=studentService.GetAllStudents();
                if (stu != null)
                {
                    return new OkObjectResult(stu);
                }
                else { 
                    return StatusCode(StatusCodes.Status204NoContent);
                }
            }
            catch(Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // GET api/<StudentController>/5
        [HttpGet]
        [Route("GetStudentById/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var stu = studentService.GetStudentById(id);
                if (stu != null)
                {
                    return new OkObjectResult(stu);
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

        // POST api/<StudentController>
        [HttpPost]
        [Route("AddStudent")]
        public IActionResult Post([FromBody] Student stu)
        {
            try
            {
                int result=studentService.AddStudent(stu);
                if (result>=1)
                {
                    return StatusCode(StatusCodes.Status201Created);
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

        // PUT api/<StudentController>/5
        [HttpPut]
        [Route("UpdateStudent/")]
        public IActionResult Put(int id, [FromBody] Student stu)
        {
            try {
                int result = studentService.UpdateStudent(stu);
                if (result >= 1)
                {
                    return StatusCode(StatusCodes.Status201Created);
                }
                else
                {
                    return StatusCode(StatusCodes.Status204NoContent);
                }

            }
            catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // DELETE api/<StudentController>/5
        [HttpDelete]
        [Route("DeleteStudent/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                int result = studentService.DeleteStudent(id);
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
