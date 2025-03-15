using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASPDemoTQ.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult EmployeeDetails()
        {
            List<string> cities = new List<string>() { "Select City", "Kolhapur", "Pune", "Nagpur", "Mumbai", "Satara", "Sangli" };
            ViewData["citites"] = new SelectList(cities);

            List<string> dept = new List<string>() { "Select department","IT","MECH","EE","ENTC"};
            ViewData["depts"]=new SelectList(dept);
            
            return View();
        }


        [HttpPost]
        public IActionResult EmployeeDetails(IFormCollection form)
        {
            ViewBag.Name = form["fname"];
            ViewBag.Address = form["Address"];
            ViewBag.Skills = form["skills"];
            ViewBag.Dept = form["depts"];
            ViewBag.Gender = form["gender"];
            ViewBag.Education = form["edu"];
            ViewBag.City = form["citites"];

            return View("EmpDisplay");
        }

    }
}

