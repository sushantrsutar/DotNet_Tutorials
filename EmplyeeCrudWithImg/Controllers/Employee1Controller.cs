using EmplyeeCrudWithImg.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmplyeeCrudWithImg.Controllers
{
    public class Employee1Controller : Controller
    {
        ApplicationDbContex db;
        DepartmentCrud Dcrud;
        EmployeeCrud Ecrud;

        private Microsoft.AspNetCore.Hosting.IHostingEnvironment env;

        public Employee1Controller(ApplicationDbContex db, Microsoft.AspNetCore.Hosting.IHostingEnvironment env) { 
            this.db = db;
            
            Dcrud = new DepartmentCrud(this.db);
            Ecrud = new EmployeeCrud(this.db);
            this.env = env;
        }
       
        // GET: Employee1Controller
        public ActionResult Index()
        {
            var model=Ecrud.GetEmployees();
           
            
            return View(model);
        }

        // GET: Employee1Controller/Details/5
        public ActionResult Details(int id)
        {
            var model=Ecrud.GetEmployeeById(id);
            return View(model);
        }

        // GET: Employee1Controller/Create
        public ActionResult Create()
        {

            var dept = Dcrud.GetDepartments();
            
            ViewBag.Dept = dept;
            return View();
        }

        // POST: Employee1Controller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee1 employee1,IFormFile file)
        {
            try
            {
                using (var fs = new FileStream(env.WebRootPath + "\\images\\" + file.FileName, FileMode.Create, FileAccess.Write))
                {
                    file.CopyTo(fs);
                }
                employee1.EmpImage = "~/images/"+ file.FileName;
                int result = Ecrud.AddEmpoyee(employee1);
                if (result >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else { 
                    return View(employee1);
                }
            }
            catch(Exception ex)
            {
                return View();
                
            }
        }

        // GET: Employee1Controller/Edit/5
        public ActionResult Edit(int id)
        {
            var emp=Ecrud.GetEmployeeById(id);
            ViewBag.depts = Dcrud.GetDepartments().ToList();
            TempData["oldimage"] = emp.EmpImage;
            TempData.Keep("oldimage");
            return View(emp);
        }

        // POST: Employee1Controller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee1 e,IFormFile file)
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
                    e.EmpImage = "~/images/" + file.FileName;//override image
                    string[] str = oldimageurl.Split("/");
                    string str1 = (str[str.Length - 1]);
                    string path = env.WebRootPath + "\\images\\" + str1;
                    System.IO.File.Delete(path);
                }
                else
                {
                    e.EmpImage = oldimageurl;
                }
                int result = Ecrud.UpadateEmployee(e);
                if (result >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return View();
            }
        }

        // GET: Employee1Controller/Delete/5
        public ActionResult Delete(int id)
        {
            var model=Ecrud.GetEmployeeById(id);
            TempData["oldimage"] = model.EmpImage;
            TempData.Keep("oldimage");
            return View(model);
        }

        // POST: Employee1Controller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            try
            {
                string oldimageurl = TempData["oldimage"].ToString();
                string[] str = oldimageurl.Split("/");
                string str1= (str[str.Length - 1]);
                string path = env.WebRootPath + "\\images\\" + str1;
                System.IO.File.Delete(path);

                int result=Ecrud.DeleteEmployee(id);
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
