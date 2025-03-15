namespace EntityFrameworkDemoTq.Models
{
    public class MovieCrud
    {
        private readonly ApplicationDbContex db;
        public MovieCrud(ApplicationDbContex db) { 
            this.db = db;
        }

        public IEnumerable<Movie> GetAllMovies() { 
            return db.Movies.ToList();
        }

        public Movie GetMovieById(int id) {
            return db.Movies.Where(x => x.Id == id).FirstOrDefault();
        }

        public int AddMovie(Movie movie) {
            int result = 0;
            db.Movies.Add(movie);
            result = db.SaveChanges();
            return result;
        }

        public int UpdateMovie(Movie movie) {
            int result = 0;
            var m1 = db.Movies.Where(x => x.Id == movie.Id).FirstOrDefault();
            if (m1 != null) {
                m1.MovieName = movie.MovieName;
                m1.ActorName = movie.ActorName;
                m1.ProducerName = movie.ProducerName;
                result = db.SaveChanges();
            }
            return result;
        }

        public int DeleteMovie(int id) {
            int result = 0;
            var m1 = db.Movies.Where(x => x.Id == id).FirstOrDefault();
            if (m1 != null) { 
                db.Movies.Remove(m1);
                result = db.SaveChanges();
            }
            return result;
        }
    }
}
