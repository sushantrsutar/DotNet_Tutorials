using EmplyeeCrudWithImg.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmplyeeCrudWithImg.Controllers
{
    public class Department1Controller : Controller
    {
        ApplicationDbContex db;
        DepartmentCrud Dcrud;
        public Department1Controller(ApplicationDbContex db) {
            this.db = db;
            Dcrud=new DepartmentCrud(this.db);
        
        }
        // GET: Department1Controller
        public ActionResult Index()
        { 
            var model=Dcrud.GetDepartments();
            return View(model);
        }

        // GET: Department1Controller/Details/5
        public ActionResult Details(int id)
        {
            var model = Dcrud.GetDepartmentByid(id);
            return View(model);
        }

        // GET: Department1Controller/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Department1Controller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Department1 department1)
        {
            try
            {
                int result = Dcrud.AddDepartment(department1);
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

        // GET: Department1Controller/Edit/5
        public ActionResult Edit(int id)
        {
            var model = Dcrud.GetDepartmentByid(id);
            return View(model);
        }

        // POST: Department1Controller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Department1 department1)
        {
            try
            {
                int result=Dcrud.UpdateDepartment(department1);
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

        // GET: Department1Controller/Delete/5
        public ActionResult Delete(int id)
        {
            var model = Dcrud.GetDepartmentByid(id);
            return View(model);
        }

        // POST: Department1Controller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            try
            {
                int result=Dcrud.DeleteDepartment(id);
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
    }
}
