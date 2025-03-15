using CRUDwithImage.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDwithImage.Controllers
{
    public class CategoryController : Controller

    {
        ApplicationDbContex db;
        CategoryCrud crud;

        public CategoryController(ApplicationDbContex db) { 
            this.db = db;
            crud = new CategoryCrud(this.db);
        }

        // GET: CategoryController
        public ActionResult Index()
        {
            var model = crud.GetCategories();
            return View(model);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            return View(crud.GetCategoryById(id));
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            try
            {   
                int result=crud.AddCategory(category);
                if (result >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else { 
                    return View();
                }
                
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(crud.GetCategoryById(id));
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category category)
        {
            try
            {   
                int result=crud.UpdateCategory(category);
                if (result >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else { 
                    return View() ;
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(crud.GetCategoryById(id));
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            try
            {
                int result=crud.DeleteCategory(id);
                if (result >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }
    }
}
