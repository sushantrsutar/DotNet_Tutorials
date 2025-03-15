using ASPDemoTQ.Models;
using Microsoft.AspNetCore.Mvc;
using ASPDemoTQ.Models;

namespace ASPDemoTQ.Controllers

{
    public class ProductController : Controller
    {
        public IActionResult ProductList()
        {
            ViewData["message"] = "Product List";
            List<string> products = new List<string>() { "TV", "Mobile", "Laptop", "Mouse", "PenDrive" };
            ViewData["prod"]= products;

            List<Product> productlist = new List<Product>()
            { 
                new Product{Id=1,Name="Tv",Price=20000 },
                new Product{Id=2,Name="Mobile",Price=20000 },
                new Product{Id=3,Name="Pendrive",Price=20000 },
                new Product{Id=4,Name="Laptop",Price=20000 },
            };

            ViewData["list"]= productlist;

            //product is property
            ViewBag.product = productlist;
                return View();
        }
    }
}
