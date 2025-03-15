using ADOCRUDdemoTQ.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ADOCRUDdemoTQ.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IConfiguration configuration;
        private EmployeeCRUD db;

        public EmployeeController(IConfiguration configuration) { 
            this.configuration = configuration;
            db=new EmployeeCRUD(this.configuration);
        }

        // to display emp list
        public ActionResult Index()
        {
            var list=db.GetEmployees();
            return View(list);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST:form submit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee emp)
        {
            try
            {   int result=db.AddEmployee(emp);
                if (result >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else {
                    TempData["message"] = "Not able to add employee";
                    return View();
                }
            }
            catch(Exception ex)
            {
                TempData["exp"]=ex.Message;
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            var emp=db.GetEmployeeById(id);
            return View(emp);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee emp)
        {
            try
            {
                int result = db.UpdateEmployee(emp);
                if (result >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    TempData["message"] = "Not able to add employee";
                    return View();
                }
            }
            catch (Exception ex)
            {
                TempData["exp"] = ex.Message;
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            var emp = db.GetEmployeeById(id);
            return View(emp);
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteConirm(int id)
        {
            try
            {
                int result = db.DeleteEmployee(id);
                if (result >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    TempData["message"] = "Not able to add employee";
                    return View();
                }
            }
            catch (Exception ex)
            {
                TempData["exp"] = ex.Message;
                return View();
            }
        }
    }
}
