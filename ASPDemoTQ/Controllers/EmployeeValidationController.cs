using ASPDemoTQ.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPDemoTQ.Controllers
{
    public class EmployeeValidationController : Controller
    {
        public IActionResult AddEmployee() { 
            return View();
        }
        [HttpPost]
        public IActionResult AddEmployee(Employee emp)
        {
            if (!ModelState.IsValid) {
                TempData["error"] = "Employee not added";
               
                return View(emp);
            }
            TempData["success"] = "Employee adeed";
            return View();
        }
    }
}
