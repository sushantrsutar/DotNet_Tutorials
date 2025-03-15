using EntityFrameworkDemoTq.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkDemoTq.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContex db;
        private EmployeeCRUD crud;

        public EmployeeController(ApplicationDbContex db) { 
            this.db = db;
            crud = new EmployeeCRUD(this.db);
        }
        // GET: EmployeeController
        public ActionResult Index()
        {
            return View(crud.GetEmployees());
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            var model=crud.GetEmployeeById(id);
            return View(model);
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee emp)
        {
            try
            {   
                int result=crud.AddEmployee(emp);
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

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            var emp=crud.GetEmployeeById(id);
            return View(emp);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee emp)
        {
            try
            {
                int result = crud.UpdateEmployee(emp);
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

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {   
            var emp=crud.GetEmployeeById(id);
            return View(emp);
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            try
            {   
                int result=crud.DeleteEmployee(id);
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
