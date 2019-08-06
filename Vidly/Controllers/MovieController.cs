using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        protected ApplicationDbContext _context;

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
            var movies = _context.Movies.ToList();

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
    }
}