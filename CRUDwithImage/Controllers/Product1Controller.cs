using CRUDwithImage.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDwithImage.Controllers
{
    public class Product1Controller : Controller
    {
        ApplicationDbContex db;
        Product1crud Pcrud;
        CategoryCrud Ccrud;
        private Microsoft.AspNetCore.Hosting.IHostingEnvironment env;


        public Product1Controller(ApplicationDbContex db, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            this.db = db;
            Pcrud = new Product1crud(this.db);
            Ccrud = new CategoryCrud(this.db);
            this.env = env;
        }

        // GET: Product1Controller
        public ActionResult Index()
        {
            var model=Pcrud.GetProduct1s();
            return View(model);
        }

       // GET: Product1Controller/Details/5
        public ActionResult Details(int id)
        {
            var model=Pcrud.GetProduct1ById(id);
            return View(model);
        }

       // GET: Product1Controller/Create
        public ActionResult Create()
        {
            ViewBag.Catagaries=Ccrud.GetCategories();
            return View();
        }

        // POST: Product1Controller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product1 product1,IFormFile file)
        {
            try
            {
                using (var fs = new FileStream(env.WebRootPath + "\\images\\" + file.FileName, FileMode.Create, FileAccess.Write)) 
                { 
                    file.CopyTo(fs);
                }
                    product1.imageUrl ="~/images/"+ file.FileName;
                    int result=Pcrud.AddProduct(product1);
                if (result >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else { 
                    return View(product1);
                }
                

            }
            catch(Exception Ex)
            {
                return View();
            }
        }

        // GET: Product1Controller/Edit/5
        public ActionResult Edit(int id)
        {
            //fetch product by id
            var p=Pcrud.GetProduct1ById(id);
            //to display category list
            ViewBag.Catagaries = Ccrud.GetCategories();
            //if user chang the image we need to delete old image in post call
            //to delete old image we need hold ,we use tempdata
            TempData["oldimage"]=p.imageUrl;
            TempData.Keep("oldimage");
            return View(p);
        }

        // POST: Product1Controller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product1 p,IFormFile file)
        {
            try
            {
                string oldimageurl = TempData["oldimage"].ToString();
                if (file != null)
                {
                    using (var fs = new FileStream(env.WebRootPath + "\\images\\" + file.FileName, FileMode.Create, FileAccess.Write))
                    {
                        file.CopyTo(fs);
                    }
                    p.imageUrl = "~/images/" + file.FileName;//override image
                    string[] str = oldimageurl.Split("/");
                    string str1 = (str[str.Length - 1]);
                    string path = env.WebRootPath + "\\images\\" + str1;
                    System.IO.File.Delete(path);
                }
                else {
                    p.imageUrl = oldimageurl;
                }
                    int result=Pcrud.UpdateProduct(p);
                if (result >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else { 
                    return View();
                }
                  
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Product1Controller/Delete/5
        public ActionResult Delete(int id)
        {
            var model=Pcrud.GetProduct1ById(id);
            TempData["oldimage"] = model.imageUrl;
            TempData.Keep("oldimage");
            return View(model);
        }

        // POST: Product1Controller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            try
            {
                string oldimageurl = TempData["oldimage"].ToString();
                string[] str = oldimageurl.Split("/");
                string str1 = (str[str.Length - 1]);
                string path = env.WebRootPath + "\\images\\" + str1;
                System.IO.File.Delete(path);

                int result = Pcrud.DeleteProduct(id);

                if (result >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();
                }

            }
            catch(Exception ex)
            {
                return View();
            }
        }
    }
}
