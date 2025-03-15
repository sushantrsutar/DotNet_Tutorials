using EntityFrameworkDemoTq.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkDemoTq.Controllers
{
    public class MovieController : Controller
    {
        private readonly ApplicationDbContex db;
        private MovieCrud movieCrud;

        public MovieController(ApplicationDbContex db) { 
            this.db = db;
            movieCrud=new MovieCrud(db);
        }
        // GET: MovieController
        public ActionResult Index()
        {
            return View(movieCrud.GetAllMovies());
        }

        // GET: MovieController/Details/5
        public ActionResult Details(int id)
        {
            var movie=movieCrud.GetMovieById(id);
            return View(movie);
        }

        // GET: MovieController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MovieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movie movie)
        {
            try
            {   int result=movieCrud.AddMovie(movie);
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

        // GET: MovieController/Edit/5
        public ActionResult Edit(int id)
        {
            var movie = movieCrud.GetMovieById(id);
            return View(movie);
        }

        // POST: MovieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Movie movie)
        {
            try
            {
                int result=movieCrud.UpdateMovie(movie);
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

        // GET: MovieController/Delete/5
        public ActionResult Delete(int id)
        {   
            var movie= movieCrud.GetMovieById(id);
            return View(movie);
        }

        // POST: MovieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            try
            {   
                int result=movieCrud.DeleteMovie(id);
                if (result >= 1) {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
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
