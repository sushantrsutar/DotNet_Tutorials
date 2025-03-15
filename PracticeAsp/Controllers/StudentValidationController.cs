using Microsoft.AspNetCore.Mvc;
using PracticeAsp.Models;

namespace PracticeAsp.Controllers
{
    public class StudentValidationController : Controller
    {
        
        public IActionResult AddStudent()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(Student stu)
        {   
           
            if (!ModelState.IsValid) {
                ViewBag.Error = "Enter Valid data";
                return View();
            }
            
            return View("StudentDisplay",stu);
        }


    }
}
