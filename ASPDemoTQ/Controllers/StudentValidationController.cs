using Microsoft.AspNetCore.Mvc;

namespace ASPDemoTQ.Controllers
{
    public class StudentValidationController : Controller
    {
        public IActionResult AddStudent()
        {
            return View();
        }
    }
}
