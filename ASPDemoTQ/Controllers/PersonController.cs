using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASPDemoTQ.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]//show form
        public IActionResult PersonalDetails()
        {
            List<string> cities = new List<string>() { "Select City","Kolhapur","Pune", "Nagpur", "Mumbai", "Satara", "Sangli" };
            ViewData["citites"] = new SelectList(cities);

            return View();
        }

        [HttpPost]//form submit
        public IActionResult PersonalDetails(IFormCollection form)
        {
            ViewBag.Name = form["fname"];
            ViewBag.Address = form["address"];
            ViewBag.Gender = form["gender"];
            ViewBag.Education = form["edu"];
            ViewBag.City = form["citites"];
            return View("Display");
        }

        //[HttpPost]
        //public IActionResult PersonalDetails(ICollection<string> fname, ICollection<string> edu)//formCollection -->class
        //{
        //    ViewBag.Name = fname;
        //    ViewBag.Address = form["address"];
        //    ViewBag.Gender = form["gender"];
        //    ViewBag.Education = edu;
        //    ViewBag.City = form["citites"];
        //    return View("Display");
        //}
    }
}
