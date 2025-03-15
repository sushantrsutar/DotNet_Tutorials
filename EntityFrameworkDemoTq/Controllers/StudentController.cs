using EntityFrameworkDemoTq.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkDemoTq.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContex db;
        private StudentCrudcs crud;

        public StudentController(ApplicationDbContex db) { 
            this.db = db;
            crud = new StudentCrudcs(this.db);
        }
        // GET: StudentController
        public ActionResult Index()
        {
            return View(crud.GetStudents());
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            var model=crud.GetStudentById(id);
            return View(model);
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student stu)
        {
            try
            {
                int result=crud.AddStudent(stu);
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

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            var model =crud.GetStudentById(id);
            return View(model);
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Student stu)
        {
            try
            {
                int result= crud.UpdateStudent(stu);
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

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            var stu = crud.GetStudentById(id);
            return View(stu);
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        
        public ActionResult DeleteConfirm(int id)
        {
            try
            {   int result=crud.DeleteStudent(id);
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
