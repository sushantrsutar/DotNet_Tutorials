using Microsoft.AspNetCore.Mvc;
using ASPDemoTQ.Models;

namespace ASPDemoTQ.Controllers
{
    public class BookController : Controller
    {
        public IActionResult BookList()
        {
            ViewData["message"] = "Book list";
            List<string> books = new List<string>() { "Book1","Book2","Book3"};
            ViewData["data"]=books;

            List<Book>booklist = new List<Book>() {  
                new Book{Id=101,Name="Book1",Price=120 },
                new Book{Id=102,Name="Book2",Price=120 },
                new Book{Id=103,Name="Book3",Price=120 },
                new Book{Id=104,Name="Book4",Price=120 },
            };

            ViewData["bookdata"]=booklist;

            return View();
        }
    }
}
