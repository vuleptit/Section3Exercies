using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        private ApplicationDbContext _context;

        public MovieController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Movie
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MovieList()
        {
            var movies = _context.Movies.Include(c => c.Genre).ToList();

            ViewBag.Movies = movies;

            return View("MovieList");
        }

        public ActionResult MovieDetail(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

            ViewBag.Movie = movie;
            if(movie == null)
            {
                return new HttpNotFoundResult();
            }

            return View("MovieDetail");
        }

        public ActionResult NewMovie()
        {
            var genres = _context.Genres.ToList();

            ViewBag.Genres = genres;

            return View("MovieForm");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MovieSaving(Movie movie)
        {
            if (ModelState.IsValid)
            {
                if (movie.Id == null)
                {
                    if (movie.GenreId != null)
                        movie.Genre = _context.Genres.Single(c => c.Id == movie.GenreId);
                    _context.Movies.Add(movie);
                }
                else
                {
                    var movieInDb = _context.Movies.Single(c => c.Id == movie.Id);

                    movieInDb.Genre = movie.Genre;
                    movieInDb.GenreId = movie.GenreId;
                    movieInDb.Name = movie.Name;
                    movieInDb.ReleaseDate = movie.ReleaseDate;
                    movieInDb.NumInStock = movie.NumInStock;
                }

                _context.SaveChanges();

                return RedirectToAction("MovieList", "Movie");
            }

            else
            {
                var genres = _context.Genres.ToList();

                ViewBag.Genres = genres;
                ViewBag.Movie = movie;

                return View("MovieForm", movie);
            }
         
            

        }
        

        public ActionResult MovieEdit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);
            var genres = _context.Genres.ToList();

            if (movie == null)
                return HttpNotFound();

            ViewBag.Movie = movie;
            ViewBag.Genres = genres;
            return View("MovieForm", movie);
        }
    }
}